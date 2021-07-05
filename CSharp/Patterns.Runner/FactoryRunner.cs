using System;
using Patterns.Creational.Factory;
using Patterns.Common;

namespace Patterns.Runner
{
    public class FactoryRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            BikeFactory.CreateBike(BikeType.Hybrid);
            BikeFactory.CreateBike(BikeType.Mountain);
            BikeFactory.CreateBike(BikeType.Road);
        }
    }
}
