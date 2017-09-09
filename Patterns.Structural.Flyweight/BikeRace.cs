using System;
using System.Collections.Generic;
using Patterns.Common;

namespace Patterns.Structural.Flyweight
{
    public class BikeRace : IBikeRace
    {
        private Dictionary<BikeType, Competitor> _competitors = new Dictionary<BikeType, Competitor>();

        public Competitor GetCompetitor(BikeType type)
        {
            // Decide which bike to create using lazy initialisation
            // In otherwords don't make a new instance if we're already
            // got one in the collection
            if (_competitors.ContainsKey(type))
            {
                return _competitors[type];
            }
            else
            {
                Competitor comp = null;

                switch (type)
                {
                    case BikeType.Hybrid:
                        comp = new HybridBikeCompetitor();
                        break;
                    case BikeType.Mountain:
                        comp = new MountainBikeCompetitor();
                        break;
                    case BikeType.Road:
                        comp = new RoadBikeCompetitor();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(String.Format("{0} is not a valid bike type", type));
                }

                _competitors.Add(type, comp);

                return comp;
            }
        }
    }
}
