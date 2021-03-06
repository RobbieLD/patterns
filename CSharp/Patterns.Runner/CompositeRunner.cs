﻿using System;
using Patterns.Structural.Compisite;

namespace Patterns.Runner
{
    public class CompositeRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            PrototypeBike basicBike = new PrototypeBike("BasicBike");

            PrototypeBike basicMountainBike = new PrototypeBike("BasicMountainBike");
            PrototypeBike basicRoadBike = new PrototypeBike("BasicRoadBike");

            basicBike.Add(basicMountainBike);
            basicBike.Add(basicRoadBike);


            ProductionBike speedy = new ProductionBike("Speedy");
            ProductionBike racer = new ProductionBike("Racer");

            basicRoadBike.Add(speedy);
            basicRoadBike.Add(racer);

            ProductionBike rocky = new ProductionBike("Rocky");
            ProductionBike muddy = new ProductionBike("Muddy");

            basicMountainBike.Add(rocky);
            basicMountainBike.Add(muddy);


            // Display all the bikes
            basicBike.Display();
        }
    }
}
