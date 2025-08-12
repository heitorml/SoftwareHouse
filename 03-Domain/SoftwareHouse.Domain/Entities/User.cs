using MongoDB.Bson.Serialization.Attributes;
using SoftwareHouse.CrossCutting;
using SoftwareHouse.CrossCutting.Enums;

namespace SoftwareHouse.Domain.Entities
{
    public class User : IEntity
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("Username")]
        public string Username { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("FullName")]
        public string FullName { get; set; }

        [BsonElement("Type")]
        public UserType Type { get; set; }

        [BsonElement("Active")]
        public bool Active { get; set; }

        [BsonElement("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("UpdatedAt")]
        public DateTime? UpdatedAt { get; set; }
        public User()
        {
            CreatedAt = DateTime.UtcNow;
            Active = true;
        }
    }
}
