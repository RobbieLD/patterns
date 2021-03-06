﻿using System;
using Patterns.Common;

namespace Patterns.Behavioral.Observer
{
    public class RoadBikeShop : IBikeShop
    {
        public void NotifyAboutNewBike(BikeModel model)
        {
            if(model.Type == BikeType.Road)
            {
                Console.WriteLine($" - The Road bike shop now sells the {model.Name}");
            }
        }
    }
}
