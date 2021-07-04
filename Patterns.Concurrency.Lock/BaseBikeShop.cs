
namespace Patterns.Concurrency.Lock
{
    public class BikeShop
    {
        private readonly Warehouse _warehouse;

        public BikeShop(Warehouse warehouse)
        {
            this._warehouse = warehouse;
        }

        public void SellBike()
        {
            this._warehouse.OrderBike();
        }
    }
}
