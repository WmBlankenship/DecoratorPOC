using DecoratorPOC.Core.Interfaces;

namespace DecoratorPOC.Core.Models.Decorators
{
    public abstract class BaseComponentDecorator : IComponent
    {
        private readonly IComponent _baseComponent;

        public BaseComponentDecorator(IComponent baseComponent)
        {
            _baseComponent = baseComponent;
        }

        public virtual decimal GetCost() => _baseComponent.GetCost();

        public virtual string GetDescription() => _baseComponent.GetDescription();
    }
}
