using System;

namespace Patterns.Creational.AbstractFactory
{
    public class MountainBike : IBike
    {
        public MountainBike(string name)
        {
            Console.WriteLine($"Creating the {name} mountain bike");
        }
    }
}
