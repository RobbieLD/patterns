using System;
using Patterns.Creational.AbstractFactory;

namespace Patterns.Runner
{
    public static class AbstractFactoryRunner
    {
        public static void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** ABSTRACT FACTORY PATTERN ***{Environment.NewLine}");

            IBikeShop mShop = new MountainBikeShop();
            IBikeShop rShop = new RoadBikeShop();
            IBikeShop hShop = new HybridBikeShop();

            mShop.OrderBike("Muddy");
            rShop.OrderBike("Missile");
            hShop.OrderBike("Cruser");
        }
    }
}
