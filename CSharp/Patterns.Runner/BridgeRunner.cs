using System;
using Patterns.Structural.Bridge;

namespace Patterns.Runner
{
    public class BridgeRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            AbstractRider rider = new Rider("Rob");

            rider.Bike = new MountainBike("Rocky");

            rider.RideBike();

            rider.Bike = new RoadBike("Speedy");

            rider.RideBike();
        }
    }
}
