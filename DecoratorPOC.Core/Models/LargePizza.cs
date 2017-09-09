using DecoratorPOC.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPOC.Core.Models
{
    public class LargePizza : BasePizza, IPizza
    {
        public override decimal GetCost()
        {
            return 6.00m;
        }

        public override string GetDescription()
        {
            return "Large pizza";
        }
    }
}
