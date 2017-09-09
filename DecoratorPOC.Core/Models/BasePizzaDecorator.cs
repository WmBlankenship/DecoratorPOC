using DecoratorPOC.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPOC.Core.Models
{
    public abstract class BasePizzaDecorator : IPizza
    {
        private readonly BasePizza _basePizza;

        public BasePizzaDecorator(BasePizza basePizza)
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
