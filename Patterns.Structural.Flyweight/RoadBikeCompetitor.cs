using System;

namespace Patterns.Structural.Flyweight
{
    public class RoadBikeCompetitor : Competitor
    {
        public RoadBikeCompetitor()
        {
            this._speed = 200;
        }

        public override void Ride()
        {
            Console.WriteLine("A Road bike is now riding at {0}", _speed);
        }
    }
}
