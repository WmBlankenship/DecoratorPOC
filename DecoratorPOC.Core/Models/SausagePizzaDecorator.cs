using DecoratorPOC.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPOC.Core.Models
{
    public class SausagePizzaDecorator : BasePizzaDecorator
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
