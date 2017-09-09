﻿using DecoratorPOC.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPOC.Core.Models
{
    public class PepperoniPizzaDecorator : BasePizzaDecorator
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
