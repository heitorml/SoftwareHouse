using SoftwareHouse.Dto.Reponses.User;
using SoftwareHouse.Dto.Request.User;

namespace SoftwareHouse.Application.UseCases.Users.Create
{
    public interface IUserCreateUseCase
    {
        Task<UserDtoResponse> Create(UserDtoRequest userDtoRequest, CancellationToken cancellationToken = default);
    }
}
