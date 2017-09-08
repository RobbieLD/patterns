using System;

namespace Patterns.Flyweight
{
    public class HybridBikeCompetitor : Competitor
    {
        public HybridBikeCompetitor()
        {
            this._speed = 150;
        }

        public override void Ride()
        {
            Console.WriteLine("A Hybrid bike is now riding at {0}", _speed);
        }
    }
}
