using System;
using Patterns.Behavioral.PublishSubscriber;

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

            customerOne.UnsubscribeFromNewBikeNotifications();
            customerTwo.UnsubscribeFromNewBikeNotifications();

            shop.NewBikeArrived("Rocket");

            // We don't need to ubsubscribe the last customer (or any of them really) 
            // because they have the same scope as the object they subscribe to. 
            // Memory leaks only occur when objects the sunscriber object is disposed
            // but's it's subscribtion in the subscribed object last on.
            // This is a design problem and should be solved at design time.
        }
    }
}
