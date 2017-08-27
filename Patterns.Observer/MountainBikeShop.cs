using System;
using System.Collections.Generic;
using System.Text;
using Patterns.Common;

namespace Patterns.Observer
{
    public class MountainBikeShop : IBikeShop
    {
        public void NotifyAboutNewBike(BikeModel model)
        {
            if (model.Type == BikeType.Mountain)
            {
                Console.WriteLine($" - The Mountain bike shop now sells the {model.Name}");
            }
        }
    }
}
