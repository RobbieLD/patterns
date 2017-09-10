using System.Collections.Generic;

namespace Patterns.Behavioral.Visitor
{
    public class BikeShop
    {
        private List<IBike> _bikes = new List<IBike>();

        public void Attach(IBike bike)
        {
            _bikes.Add(bike);
        }

        public void Detach(IBike bike)
        {
            _bikes.Remove(bike);
        }

        public void AcceptVisitor(IRobot robotVisitor)
        {
            foreach(IBike bike in _bikes)
            {
                bike.AcceptRobot(robotVisitor);
            }
        }

        public void DisplayBikes()
        {
            _bikes.ForEach(b => b.Display());
        }

    }
}
