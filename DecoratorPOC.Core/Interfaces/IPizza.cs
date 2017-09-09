using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPOC.Core.Interfaces
{
    public interface IPizza
    {
        string GetDescription();
        decimal GetCost();
    }
}
