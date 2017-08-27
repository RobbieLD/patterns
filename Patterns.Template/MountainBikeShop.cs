using System;

namespace Patterns.Template
{
    public class MountainBikeShop : BaseBikeShop
    {
        protected override void AddBrakes()
        {
            Console.WriteLine(" - Adding mountain bike brakes");
        }

        protected override void AddShocks()
        {
            Console.WriteLine(" - Adding mountain bike shocks");
        }

        protected override void IntroduceBike()
        {
            Console.WriteLine($"Building a mountain bike");
        }
    }
}
