using Patterns.Common;
using System;
using Patterns.Behavioral.Observer;

namespace Patterns.Runner
{
    public class ObserverRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            // Make a new bike manufacturer;
            IBikeManufacturer manufacturer = new BikeManufacturer();

            // Make some shops
            IBikeShop roadBikeShop = new RoadBikeShop();
            IBikeShop mountainBikeShop = new MountainBikeShop();

            // Register the shops for updates
            WeakReference<IBikeShop> roadBikeShopRef = manufacturer.RegisterShop(roadBikeShop);
            WeakReference<IBikeShop> mountainBikehopRef = manufacturer.RegisterShop(mountainBikeShop);

            // Announce some new bikes
            manufacturer.NotifyShops(new BikeModel
            {
                Name = "Mountain King",
                Type = BikeType.Mountain
            });


            manufacturer.NotifyShops(new BikeModel
            {
                Name = "Road Racer",
                Type = BikeType.Road
            });
            
        }
    }
}
