using System;
using Patterns.Common;

namespace Patterns.Behavioral.Visitor
{
    public class HybridBike : Bike
    {
        public HybridBike(string name) : base(name, BikeType.Hybrid)
        {
            Colour = ConsoleColor.Gray;
            TirePressure = 60;
        }
    }
}