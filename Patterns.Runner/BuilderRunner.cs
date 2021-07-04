using Patterns.Creational.Builder;
using System;

namespace Patterns.Runner
{
    public class BuilderRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** BUILDER PATTERN ***{Environment.NewLine}");

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
