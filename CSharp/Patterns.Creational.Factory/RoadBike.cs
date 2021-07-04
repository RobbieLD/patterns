using System;

namespace Patterns.Creational.Factory
{
    public class RoadBike : IBike
    {
        public RoadBike()
        {
            Console.WriteLine("Building a Road Bike");
        }
    }
}
