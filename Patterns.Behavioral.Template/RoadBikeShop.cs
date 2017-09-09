using System;

namespace Patterns.Behavioral.Template
{
    public class RoadBikeShop : BaseBikeShop
    {
        protected override void AddBrakes()
        {
            Console.WriteLine(" - Adding road bike brakes");
        }

        protected override void AddShocks()
        {
            Console.WriteLine(" - Adding road bike shocks");
        }

        protected override void IntroduceBike()
        {
            Console.WriteLine($"Building a road bike");
        }
    }
}
