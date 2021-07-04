using System;

namespace Patterns.Behavioral.Iterator
{
    public class Bike
    {
        public int ProductionNumber { get; set; }
        public virtual void Build()
        {
            Console.WriteLine($"Building bike number {ProductionNumber}");
        }

        public Bike Next { get; set; }
    }
}
