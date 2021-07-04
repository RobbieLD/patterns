using System;
using Patterns.Behavioral.Template;

namespace Patterns.Runner
{
    public class TemplateRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** TEMPLATE PATTERN ***{Environment.NewLine}");
            
            // Make a mountain bike workshop to build some mountain bikes
            MountainBikeShop mountainBikesRUS = new MountainBikeShop();
            mountainBikesRUS.BuildBike();

            // Make a Road bike shop to build some road bikes
            RoadBikeShop weLikeRoadBikes = new RoadBikeShop();
            weLikeRoadBikes.BuildBike();
            weLikeRoadBikes.BuildBike();
        }
    }
}
