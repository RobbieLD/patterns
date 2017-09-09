using System;

namespace Patterns.Creational.Factory
{
    public class MountainBike : IBike
    {
        public MountainBike()
        {
            Console.WriteLine("Building a Mountain Bike");
        }
    }
}
