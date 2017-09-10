using DecoratorPOC.Core.Interfaces;

namespace DecoratorPOC.Core.Models.Decorators
{
    public class AlphaDecorator : BaseComponentDecorator, IComponent
    {
        public AlphaDecorator(IComponent baseComponent)
            : base(baseComponent)
        {
        }

        public override decimal GetCost() => base.GetCost() + .50m;

        public override string GetDescription() => $"{base.GetDescription()}, alpha";
    }
}
