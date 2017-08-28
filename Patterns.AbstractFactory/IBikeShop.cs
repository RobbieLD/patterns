using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractFactory
{
    public interface IBikeShop
    {
        IBike OrderBike(string name);
    }
}
