using Microsoft.AspNetCore.Mvc;
using SoftwareHouse.Application.UseCases.Users.Create;
using SoftwareHouse.Dto.Request.User;

namespace SoftwareHouse.Users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserDtoRequest request,
           [FromServices] IUserCreateUseCase useCase, CancellationToken cancellationToken = default) =>
             Ok(await useCase.Create(request, cancellationToken));
    }
}
