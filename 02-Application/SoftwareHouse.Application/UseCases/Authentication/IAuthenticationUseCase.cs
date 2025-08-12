using SoftwareHouse.Dto.Reponses.Auth;
using SoftwareHouse.Dto.Request.Auth;

namespace SoftwareHouse.Application.UseCases.Authentication
{
    public interface IAuthenticationUseCase
    {
        Task<AuthDtoResponse> AuthenticateAsync(AuthDtoRequest request, CancellationToken cancellationToken = default);
    }
}
