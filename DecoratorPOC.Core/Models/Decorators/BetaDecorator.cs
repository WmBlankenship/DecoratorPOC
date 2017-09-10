using DecoratorPOC.Core.Interfaces;

namespace DecoratorPOC.Core.Models.Decorators
{
    public class BetaDecorator : BaseComponentDecorator, IComponent
    {
        public BetaDecorator(IComponent baseComponent)
            : base(baseComponent)
        {
        }

        public override decimal GetCost() => base.GetCost() + 1m;

        public override string GetDescription() => $"{base.GetDescription()}, beta";
    }
}
