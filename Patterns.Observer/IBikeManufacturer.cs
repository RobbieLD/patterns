using System;

namespace Patterns.Observer
{
    public interface IBikeManufacturer
    {
        WeakReference<IBikeShop> RegisterShop(IBikeShop bikeShop);
        void UnregisterShop(WeakReference<IBikeShop> bikeShope);
        void NotifyShops(BikeModel model);
    }
}
