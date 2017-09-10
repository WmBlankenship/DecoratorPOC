using DecoratorPOC.Core.Interfaces;

namespace DecoratorPOC.Core.Models
{
    public class LargePizza : IPizza
    {
        public decimal GetCost()
        {
            return 6.00m;
        }

        public string GetDescription()
        {
            return "Large pizza";
        }
    }
}
