using System;
using Patterns.Structural.Bridge;

namespace Patterns.Runner
{
    public class BridgeRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** BRIDGE PATTERN ***{Environment.NewLine}");

            AbstractRider rider = new Rider("Rob");

            rider.Bike = new MountainBike("Rocky");

            rider.RideBike();

            rider.Bike = new RoadBike("Speedy");

            rider.RideBike();
        }
    }
}
