using SoftwareHouse.CrossCutting.Enums;

namespace SoftwareHouse.Dto.Reponses.User
{
    public class UserDtoResponse
    {
        public string Code { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public UserType Type { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
