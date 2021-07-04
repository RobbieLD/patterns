using System;

namespace Patterns.Structural.Bridge
{
    public class Rider : AbstractRider
    {

        public Rider(string name) : base(name)
        { }

        public override void RideBike()
        {
            Console.Write("{0} is going for a ride ", _name);
            this.Bike.Ride();
        }
    }
}
