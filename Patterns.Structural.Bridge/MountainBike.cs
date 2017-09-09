using System;

namespace Patterns.Structural.Bridge
{
    public class MountainBike : AbstractBike
    {
        public MountainBike(string name) : base(name)
        {
        }

        public override void Ride()
        {
            Console.WriteLine("riding the {0} mountain bike", _bikeType);
        }
    }
}
