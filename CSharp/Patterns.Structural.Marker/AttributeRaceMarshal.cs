using System;
using System.Collections.Generic;

namespace Patterns.Structural.Marker
{
    public class AttributeRaceMarshal : BaseMarshal
    {
        public AttributeRaceMarshal(IEnumerable<Bike> entrants)
            : base(entrants)
        {
        }

        public override void StartRace()
        {
            foreach (var bike in this.Entrants)
            {
                // Only let the bikes race if they have the CanRace attribute
                if (bike.GetType().GetCustomAttributes(typeof(CanRaceAttribute), false).Length > 0)
                {
                    bike.IsRacing = true;
                }
            }
        }
    }
}
