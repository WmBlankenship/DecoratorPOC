using DecoratorPOC.Core.Interfaces;

namespace DecoratorPOC.Core.Models.Decorators
{
    public class SausagePizzaDecorator : BasePizzaDecorator, IPizza
    {
        public SausagePizzaDecorator(IPizza basePizza)
            : base(basePizza)
        {

        }

        public override decimal GetCost()
        {
            return base.GetCost() + 1m;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, sausage";
        }
    }
}
