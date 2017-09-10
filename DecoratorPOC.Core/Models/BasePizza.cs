using DecoratorPOC.Core.Interfaces;

namespace DecoratorPOC.Core.Models
{
    public abstract class BasePizza : IPizza
    {
        public abstract decimal GetCost();
        public abstract string GetDescription();
    }
}
