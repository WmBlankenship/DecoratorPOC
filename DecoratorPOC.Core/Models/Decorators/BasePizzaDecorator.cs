using DecoratorPOC.Core.Interfaces;

namespace DecoratorPOC.Core.Models.Decorators
{
    public abstract class BasePizzaDecorator : IPizza
    {
        private readonly IPizza _basePizza;

        public BasePizzaDecorator(IPizza basePizza)
        {
            _basePizza = basePizza;
        }

        public virtual decimal GetCost()
        {
            return _basePizza.GetCost();
        }

        public virtual string GetDescription()
        {
            return _basePizza.GetDescription();
        }
    }
}
