using System;

namespace Patterns.Prototype
{
    public class Bike : IBike
    {
        public int ProductionNumber { get; set; }
        public string ModelName { get; set; }

        public virtual IBike Clone()
        {
            return (IBike)MemberwiseClone();
        }

        public void LogBikeProuduction()
        {
            Console.WriteLine("Building {0} number {1}", ModelName, ProductionNumber);
        }
    }
}
