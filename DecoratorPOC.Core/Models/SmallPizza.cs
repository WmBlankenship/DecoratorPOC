using DecoratorPOC.Core.Interfaces;

namespace DecoratorPOC.Core.Models
{
    public class Smallizza : IPizza
    {
        public decimal GetCost()
        {
            return 3.00m;
        }

        public string GetDescription()
        {
            return "Small pizza";
        }
    }
}