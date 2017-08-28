using System;
using Patterns.Common;

namespace Patterns.Factory
{
    public static class BikeFactory
    {
        public static IBike CreateBike(BikeType type)
        {
            switch(type)
            {
                case BikeType.Mountain:
                    return new MountainBike();

                case BikeType.Road:
                    return new RoadBike();

                case BikeType.Hybrid:
                    return new HybridBike();

                default:
                    throw new ArgumentException($"{type} is not a supported bike type");
            }
        }
    }
}
