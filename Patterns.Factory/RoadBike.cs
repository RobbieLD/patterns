using System;

namespace Patterns.Factory
{
    public class RoadBike : IBike
    {
        public RoadBike()
        {
            Console.WriteLine("Building a Road Bike");
        }
    }
}
