using System;

namespace Patterns.Factory
{
    public class HybridBike : IBike
    {
        public HybridBike()
        {
            Console.WriteLine("Building a Hybrid Bike");
        }
    }
}
