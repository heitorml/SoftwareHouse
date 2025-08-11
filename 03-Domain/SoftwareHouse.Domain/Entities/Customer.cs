using SoftwareHouse.CrossCutting;

namespace SoftwareHouse.Domain.Entities
{
    public class Customer : IEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string IdentificationNumber { get; set; }
        public string Responsible { get; set; }
        public string Phone { get; set; }
        public string Owner { get; set; }
        public bool Active { get; set; }
        public List<Project> Projects { get; set; }
    }
}
