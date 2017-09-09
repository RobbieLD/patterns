using System;
using Patterns.Common;

namespace Patterns.Behavioral.Observer
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
