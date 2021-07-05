using Patterns.Creational.Builder;
using System;

namespace Patterns.Runner
{
    public class BuilderRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            BikeBuilder mBuilder = new MountainBikeBuilder();
            BikeBuilder rBuilder = new RoadBikeBuilder();

            BikeShop shop = new BikeShop();

            shop.Build(mBuilder);

            mBuilder.Bike.DescribeBike();

            shop.Build(rBuilder);

            rBuilder.Bike.DescribeBike();
        }
    }
}
