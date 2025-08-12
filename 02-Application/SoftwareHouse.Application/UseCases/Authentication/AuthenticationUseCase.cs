using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SoftwareHouse.Dto.Reponses.Auth;
using SoftwareHouse.Dto.Request.Auth;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SoftwareHouse.Application.UseCases.Authentication
{
    public class AuthenticationUseCase : IAuthenticationUseCase
    {
        private readonly IConfiguration _configuration;

        public AuthenticationUseCase(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<AuthDtoResponse?> AuthenticateAsync(AuthDtoRequest request, CancellationToken cancellationToken = default)
        {
            if (request.Username == "admin" && request.Password == "password")
            {
                var jwtSettings = _configuration.GetSection("Jwt");
                var key = Encoding.UTF8.GetBytes(jwtSettings["Key"]);
                var expiresDate = DateTime.UtcNow.AddHours(1);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, request.Username)
                    }),
                    Expires = expiresDate,
                    Issuer = jwtSettings["Issuer"],
                    Audience = jwtSettings["Audience"],
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(key), 
                        SecurityAlgorithms.HmacSha256Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);

                var result = new AuthDtoResponse(tokenHandler.WriteToken(token), expiresDate);

                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
