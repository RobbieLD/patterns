using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.PublishSubscriber
{
    public class BikeCustomer
    {
        private readonly string _name;
        private readonly IBikeShop _shop;
        public BikeCustomer(IBikeShop shop, string name)
        {
            _shop = shop;
            _name = name;

            _shop.NewBikeArrivedEvent += HandleNewBikeEvents;
            /**
             * TODO: Instead of the normal way of the simply way of subscribing to events
             * and then either allowing the GC to clean up after you or implimenting 
             * IDispoable, we're going to use The WeakEventPattern here. 
             */

        }

        private void HandleNewBikeEvents(object sender, NewBikeEventArgs args)
        {
            Console.WriteLine($" - {_name} just found out that {_shop.Name} now sells the {args.NameOfBike} bike");
        }
    }
}
