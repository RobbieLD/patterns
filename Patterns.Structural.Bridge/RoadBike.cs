using System;

namespace Patterns.Structural.Bridge
{
    public class RoadBike : AbstractBike
    {
        public RoadBike(string name) : base(name)
        {
        }

        public override void Ride()
        {
            Console.WriteLine("riding the {0} road bike", _bikeType);
        }
    }
}
