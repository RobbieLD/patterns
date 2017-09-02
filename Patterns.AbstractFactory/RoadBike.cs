using System;

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
