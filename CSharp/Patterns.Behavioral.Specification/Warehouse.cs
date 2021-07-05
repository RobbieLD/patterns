using System.Collections.Generic;
using System.Linq;

namespace Patterns.Behavioral.Specification
{
    public class Warehouse : IRepository<Bike>
    {
        private readonly BikeShopContext _dataSource;

        public Warehouse(BikeShopContext dataSource)
        {
            _dataSource = dataSource;
        }

        public IReadOnlyList<Bike> Find(Specification<Bike> specification)
        {
            return this._dataSource.Bikes
                .Where(specification.ToExpression())
                .ToList();
        }
    }
}
