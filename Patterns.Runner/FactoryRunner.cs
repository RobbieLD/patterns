﻿using System;
using Patterns.Creational.Factory;
using Patterns.Common;

namespace Patterns.Runner
{
    public class FactoryRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** FACTORY PATTERN ***{Environment.NewLine}");

            BikeFactory.CreateBike(BikeType.Hybrid);
            BikeFactory.CreateBike(BikeType.Mountain);
            BikeFactory.CreateBike(BikeType.Road);
        }
    }
}
