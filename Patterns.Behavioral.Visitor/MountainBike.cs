using System;
using Patterns.Common;

namespace Patterns.Behavioral.Visitor
{
    public class MountainBike : Bike
    {
        public MountainBike(string name) : base(name, BikeType.Mountain)
        {
            Colour = ConsoleColor.White;
            TirePressure = 30;
        }
    }
}
