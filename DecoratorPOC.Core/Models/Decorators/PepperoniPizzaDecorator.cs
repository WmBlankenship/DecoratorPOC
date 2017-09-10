using DecoratorPOC.Core.Interfaces;

namespace DecoratorPOC.Core.Models.Decorators
{ 
    public class PepperoniPizzaDecorator : BasePizzaDecorator, IPizza
    {
        public PepperoniPizzaDecorator(IPizza basePizza)
            : base(basePizza)
        {

        }

        public override decimal GetCost()
        {
            return base.GetCost() + .50m;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, pepperoni";
        }
    }
}
