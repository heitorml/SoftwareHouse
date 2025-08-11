using SoftwareHouse.CrossCutting;
using SoftwareHouse.CrossCutting.Enums;

namespace SoftwareHouse.Domain.Entities
{
    public class Project : IEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public ProjectType Type { get; set; }
        public ProjectStatus Status { get; set; }
        public string BudgetId { get; set; }
        public string CustomerId { get; set; }
        public Budget Budget { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreatAt { get; set; } = DateTime.Now;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
