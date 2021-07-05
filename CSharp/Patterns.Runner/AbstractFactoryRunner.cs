using System;
using Patterns.Creational.AbstractFactory;

namespace Patterns.Runner
{
    public class AbstractFactoryRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            IBikeShop mShop = new MountainBikeShop();
            IBikeShop rShop = new RoadBikeShop();
            IBikeShop hShop = new HybridBikeShop();

            mShop.OrderBike("Muddy");
            rShop.OrderBike("Missile");
            hShop.OrderBike("Cruser");
        }
    }
}
