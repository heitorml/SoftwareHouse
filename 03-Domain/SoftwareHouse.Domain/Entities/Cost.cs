using SoftwareHouse.CrossCutting;
using SoftwareHouse.CrossCutting.Enums;

namespace SoftwareHouse.Domain.Entities
{
    public class Cost : IEntity
    {
        public string Id { get ; set ; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int QuantityOfResources { get; set; }
        public bool Active { get; set; }
        public CostsType Type { get; set; }
    }
}
