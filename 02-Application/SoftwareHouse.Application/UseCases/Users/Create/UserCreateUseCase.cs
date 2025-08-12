using Microsoft.Extensions.Logging;
using SoftwareHouse.CrossCutting.Enums;
using SoftwareHouse.Domain.Entities;
using SoftwareHouse.Dto.Reponses.User;
using SoftwareHouse.Dto.Request.User;
using SoftwareHouse.Infrastructure.Repositories;

namespace SoftwareHouse.Application.UseCases.Users.Create
{
    public class UserCreateUseCase : IUserCreateUseCase
    {
        private readonly ILogger<UserCreateUseCase> _logger;
        private readonly IRepository<User> _repository;

        public UserCreateUseCase(ILogger<UserCreateUseCase> logger, IRepository<User> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task<UserDtoResponse> Create(UserDtoRequest userDtoRequest, CancellationToken cancellationToken = default)
        {
            var userNewer = new User
            {
                Email = userDtoRequest.Email,
                Password = userDtoRequest.Password, // Consider hashing the password before storing it
                FullName = userDtoRequest.FullName,
                Username = userDtoRequest.Username,
                Type = userDtoRequest.Type,
                CreatedAt = DateTime.UtcNow
            };

            await _repository.AddAsync(userNewer);

            return new UserDtoResponse
            {
                Code = userNewer.Id,
                Email = userNewer.Email,
                FullName = userNewer.FullName,
                Username = userNewer.Username,
                Type = userNewer.Type,
                CreatedAt = userNewer.CreatedAt
            };

        }
    }
}
