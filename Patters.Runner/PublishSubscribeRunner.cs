using System;
using System.Collections.Generic;
using System.Text;
using Patterns.PublishSubscriber;

namespace Patterns.Runner
{
    public static class PublishSubscribeRunner
    {
        public static void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** PUBLISH SUBSCRIBE PATTERN ***{Environment.NewLine}");

            // Make a bike shop
            IBikeShop shop = new BikeShop("Mountain Bike Guys");

            BikeCustomer customerOne = new BikeCustomer(shop, "Tom");
            BikeCustomer customerTwo = new BikeCustomer(shop, "Dick");
            BikeCustomer customerThree = new BikeCustomer(shop, "Harry");

            shop.NewBikeArrived("Road Runner");
            shop.NewBikeArrived("GT");
        }
    }
}
