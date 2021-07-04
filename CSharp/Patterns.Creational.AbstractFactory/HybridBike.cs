using System;

namespace Patterns.Creational.AbstractFactory
{
    public class HybridBike : IBike
    {
        public HybridBike(string name)
        {
            Console.WriteLine($"Creating the {name} hybrid bike");
        }
    }
}
