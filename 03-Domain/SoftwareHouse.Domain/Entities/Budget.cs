using SoftwareHouse.CrossCutting;
using SoftwareHouse.CrossCutting.Enums;

namespace SoftwareHouse.Domain.Entities
{
    public class Budget : IEntity
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string ProjectId { get; set; }
        public decimal CostTotal { get; set; }
        public bool Active { get; set; }
        public List<Cost> Costs { get; set; }
        public BudgetType Type { get; set; }

        public void Calculate()
        {
            if (Active &&  Costs.Any()) 
                CostTotal = Costs.Sum(Costs => Costs.Amount);
        }

    }
}
