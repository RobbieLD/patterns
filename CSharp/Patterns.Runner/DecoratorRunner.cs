﻿using Patterns.Structural.Decorator;
using System;

namespace Patterns.Runner
{
    public class DecoratorRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            // Create Some Bikes
            MountainBike mBike = new MountainBike("Red", 16, 85, 2);
            mBike.Display();

            RoadBike rBike = new RoadBike("Black", 29, 90, true);
            rBike.Display();

            // Now Decorate both the bikes with brakes
            Brakes mountainBikeWithBrakes = new Brakes(mBike);
            mountainBikeWithBrakes.AddBrakes(BrakeType.Disc);

            mountainBikeWithBrakes.Display();

            Brakes roadBikeWithBrakes = new Brakes(rBike);
            roadBikeWithBrakes.AddBrakes(BrakeType.Rim);

            roadBikeWithBrakes.Display();

            // Now Decorate the mountain bike with shocks
            Shocks mountainBikeWithShocks = new Shocks(mBike);
            mountainBikeWithShocks.AddShocks(8);


            mountainBikeWithShocks.Display();
        }
    }
}
