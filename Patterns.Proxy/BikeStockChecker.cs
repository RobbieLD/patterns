using System;
using Patterns.Common;

namespace Patterns.Proxy
{
    public class BikeStockChecker : IBikeStockChecker
    {
        private WarehouseService _service;

        public BikeStockChecker()
        {
            _service = new WarehouseService();
        }

        public int GetNumberOfMountainBikes(string warehouseName)
        {
            Console.Write("Checking {0} for mountain bikes and found ", warehouseName);
            return _service.GetNumberOfBikes(BikeType.Mountain);
        }

        public int GetNumberOfRoadBikes(string warehouseName)
        {
            Console.Write("Checking {0} for road bikes and found ", warehouseName);
            return _service.GetNumberOfBikes(BikeType.Road);
        }
    }
}
