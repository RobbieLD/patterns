using System;

namespace Patterns.Flyweight
{
    public class MountainBikeCompetitor : Competitor
    {
        public MountainBikeCompetitor()
        {
            this._speed = 100;
        }

        public override void Ride()
        {
            Console.WriteLine("A Mountain bike is now riding at {0}", _speed);
        }
    }
}
