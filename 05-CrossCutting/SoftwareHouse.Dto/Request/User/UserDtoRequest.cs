using SoftwareHouse.CrossCutting.Enums;

namespace SoftwareHouse.Dto.Request.User
{
    public class UserDtoRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public UserType Type { get; set; }
    }
}
