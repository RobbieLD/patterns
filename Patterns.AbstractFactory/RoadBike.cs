using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractFactory
{
    public class RoadBike : IBike
    {
        public RoadBike(string name)
        {
            Console.WriteLine($"Creating the {name} road bike");
        }
    }
}
