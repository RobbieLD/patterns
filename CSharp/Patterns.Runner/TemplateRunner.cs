using System;
using Patterns.Behavioral.Template;

namespace Patterns.Runner
{
    public class TemplateRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

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
