using DecoratorPOC.Core.Interfaces;

namespace DecoratorPOC.Core.Models
{
    public class SmallComponent : IComponent
    {
        public decimal GetCost() => 3.00m;

        public string GetDescription() => "Small component";
    }
}