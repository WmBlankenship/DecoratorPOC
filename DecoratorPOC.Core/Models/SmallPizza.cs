using DecoratorPOC.Core.Interfaces;

namespace DecoratorPOC.Core.Models
{
    public class Smallizza : BasePizza, IPizza
    {
        public override decimal GetCost()
        {
            return 3.00m;
        }

        public override string GetDescription()
        {
            return "Small pizza";
        }
    }
}