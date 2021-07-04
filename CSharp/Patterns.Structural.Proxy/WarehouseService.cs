using System;
using Patterns.Common;

namespace Patterns.Structural.Proxy
{
    /// <summary>
    /// This class isn't part of the proxy pattern
    /// </summary>
    class WarehouseService
    {
        public int GetNumberOfBikes(BikeType type)
        {
            if (type == BikeType.Mountain)
            {
                return new Random().Next(100);
            }
            else
            {
                return new Random().Next(100, 500);
            }
        }
    }
}
