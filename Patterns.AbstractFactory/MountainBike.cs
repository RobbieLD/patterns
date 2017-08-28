using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractFactory
{
    public class MountainBike : IBike
    {
        public MountainBike(string name)
        {
            Console.WriteLine($"Creating the {name} mountain bike");
        }
    }
}
