namespace SoftwareHouse.Dto.Reponses.Auth
{
    public class AuthDtoResponse
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public AuthDtoResponse(string token, DateTime expiration)
        {
            Token = token;
            Expiration = expiration;
        }
    }
}
