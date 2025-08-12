using Microsoft.AspNetCore.Mvc;
using SoftwareHouse.Application.UseCases.Authentication;
using SoftwareHouse.Dto.Request.Auth;

namespace SoftwareHouse.Users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthDtoRequest request,
            [FromServices] IAuthenticationUseCase useCase,
            CancellationToken cancellationToken = default)
        {
            var result = await useCase.AuthenticateAsync(request, cancellationToken);

            if (result is not null)
                return Ok(result);

            return Unauthorized();
        }
    }
}
