using DecoratorPOC.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPOC.Core.Models
{
    public abstract class BasePizza : IPizza
    {
        public abstract decimal GetCost();
        public abstract string GetDescription();
    }
}
