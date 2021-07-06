using Patterns.Structural.Twin;
using System;

namespace Patterns.Runner
{
    public class TwinRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            var hybridRoadBike = new HybridRoadbike();
            var hybridMountainBike = new HybridMountainBike();

            // Hook up the twin instances
            hybridMountainBike.Twin = hybridRoadBike;
            hybridRoadBike.Twin = hybridMountainBike;

            // Now we can call methods on road bikes from a hybrid mountain bike and visa versa.
            Console.WriteLine(hybridMountainBike.Twin.Race());
            Console.WriteLine(hybridRoadBike.Twin.Jump());
        }
    }
}
