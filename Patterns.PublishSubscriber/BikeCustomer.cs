using System;

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
            
        }

        /// <summary>
        /// This method should always be called before the object is disposed. We could impliment 
        /// IDisposable however this is not recomened my MS. Instead we should explicitly unsubscribe
        /// from events before we dispose of the subscriber objects.
        /// </summary>
        public void UnsubscribeFromNewBikeNotifications()
        {
            _shop.NewBikeArrivedEvent -= HandleNewBikeEvents;
        }

        private void HandleNewBikeEvents(object sender, NewBikeEventArgs args)
        {
            Console.WriteLine($" - {_name} just found out that {_shop.Name} now sells the {args.NameOfBike} bike");
        }
    }
}
