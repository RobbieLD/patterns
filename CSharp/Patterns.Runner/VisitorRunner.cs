using System;
using Patterns.Behavioral.Visitor;

namespace Patterns.Runner
{
    public class VisitorRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            BikeShop shop = new BikeShop();

            shop.Attach(new MountainBike("Rocky"));
            shop.Attach(new RoadBike("Speedy"));
            shop.Attach(new HybridBike("Rover"));

            shop.DisplayBikes();

            shop.AcceptVisitor(new TirePumpRobot());
            shop.AcceptVisitor(new PainterRobot());

            shop.DisplayBikes();
        }
    }
}
