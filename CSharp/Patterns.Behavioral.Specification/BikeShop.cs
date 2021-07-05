using System.Collections.Generic;

namespace Patterns.Behavioral.Specification
{
    public class BikeShop
    {
        private readonly IRepository<Bike> _repository;
        public BikeShop(IRepository<Bike> repository)
        {
            _repository = repository;
        }

        // Search methods for finding bikes for the customers
        public IReadOnlyList<Bike> GetChildrensBikes()
        {
            var atMost5Gears = new MaximumGears(5);
            var wheelSizeBetween15And20 = new WheelSizeBetween(20, 15);
            var isHybrid = new IsBikeType(BikeType.HybridBike);

            // Find all the bikes with a wheel size between 15 and 20 and either at most 5 gears or they are a hybrid
            return _repository.Find(wheelSizeBetween15And20.And(atMost5Gears.Or(isHybrid)));
        }
    }
}
