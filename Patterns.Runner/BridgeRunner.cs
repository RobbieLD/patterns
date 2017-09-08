using System;
using Patterns.Bridge;

namespace Patterns.Runner
{
    public static class BridgeRunner
    {
        public static void Run()
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
