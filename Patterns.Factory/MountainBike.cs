using System;

namespace Patterns.Factory
{
    public class MountainBike : IBike
    {
        public MountainBike()
        {
            Console.WriteLine("Building a Mountain Bike");
        }
    }
}
