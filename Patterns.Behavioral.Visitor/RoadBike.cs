using System;
using Patterns.Common;

namespace Patterns.Behavioral.Visitor
{
    public class RoadBike : Bike
    {
        public RoadBike(string name) : base(name, BikeType.Road)
        {
            Colour = ConsoleColor.DarkGray;
            TirePressure = 90;
        }
    }
}
