using System;

namespace Patterns.Creational.Factory
{
    public class HybridBike : IBike
    {
        public HybridBike()
        {
            Console.WriteLine("Building a Hybrid Bike");
        }
    }
}
