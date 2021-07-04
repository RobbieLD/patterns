using System;
using System.Collections.Generic;

namespace Patterns.Behavioral.Observer
{
    public class BikeManufacturer : IBikeManufacturer
    {
        internal readonly List<WeakReference<IBikeShop>> _shops = new List<WeakReference<IBikeShop>>();

        public void NotifyShops(BikeModel model)
        {
            Console.WriteLine($"Announcing the new {model.Name} bike");

            foreach(WeakReference<IBikeShop> shopRef in _shops.ToArray())
            {
                // C# 6 allows an out parameter to be declare when it's first used
                shopRef.TryGetTarget(out IBikeShop shop);

                // The object has been destroyed so we don't want to
                // keep it in out list of observers
                if(shop == null)
                {
                    UnregisterShop(shopRef);
                }else
                {
                    shop.NotifyAboutNewBike(model);
                }
            }

        }

        public WeakReference<IBikeShop> RegisterShop(IBikeShop bikeShop)
        {
            WeakReference<IBikeShop> shop = new WeakReference<IBikeShop>(bikeShop);
            _shops.Add(shop);

            // We want to return the weak refernce shop so we can use it to unregister later
            return shop;
        }

        public void UnregisterShop(WeakReference<IBikeShop> bikeShope)
        {
            _shops.Remove(bikeShope);
        }
    }
}
