using System;
using Patterns.Creational.Factory;
using Patterns.Common;

namespace Patterns.Runner
{
    public static class FactoryRunner
    {
        public static void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** FACTORY PATTERN ***{Environment.NewLine}");

            BikeFactory.CreateBike(BikeType.Hybrid);
            BikeFactory.CreateBike(BikeType.Mountain);
            BikeFactory.CreateBike(BikeType.Road);
        }
    }
}
