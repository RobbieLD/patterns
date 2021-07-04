using System;

namespace Patterns.Concurrency.Lock
{
    public class Warehouse
    {
        private int _bikeInventory;
        private readonly object _lock = new object();

        public Warehouse(int initialStock)
        {
            _bikeInventory = initialStock;
        }

        public void OrderBike()
        {
            lock(_lock)
            {
                // restock the bikes
                if (this._bikeInventory == 0)
                {
                    this._bikeInventory += 5;
                }

                this._bikeInventory--;
                
                // This should never be true because of the lock.
                if (this._bikeInventory < 0)
                {
                    throw new InvalidOperationException("You can't sell a bike when there's none in the warehouse");
                }
            }
        }

        // No need to lock this as it isn't updating the object's interal state.
        public int CheckStock()
        {
            return _bikeInventory;
        }
    }
}
