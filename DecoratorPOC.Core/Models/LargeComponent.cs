using DecoratorPOC.Core.Interfaces;

namespace DecoratorPOC.Core.Models
{
    public class LargeComponent : IComponent
    {
        public decimal GetCost() => 6.00m;

        public string GetDescription() => "Large component";
    }
}
