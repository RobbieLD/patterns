using System;
using Patterns.Common;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    public class MountainBikeShop : BikeShop
    {
        public MountainBikeShop(string name) : base(name)
        {
        }

        public override void FillOrder(BikeType type)
        {
            if(type == BikeType.Mountain)
            {
                Console.WriteLine($"Order for {type} bike being filled by {Name}");
            }else if(Successor != null)
            {
                Successor.FillOrder(type);
            }
            else
            {
                throw new ArgumentOutOfRangeException("This order can't be filled");
            }
        }
    }
}
