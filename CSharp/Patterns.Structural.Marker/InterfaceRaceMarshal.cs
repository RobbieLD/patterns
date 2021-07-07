using System.Collections.Generic;

namespace Patterns.Structural.Marker
{
    public class InterfaceRaceMarshal : BaseMarshal
    {
        
        public InterfaceRaceMarshal(IEnumerable<Bike> entrants)
            :base(entrants)
        {
        }

        public override void StartRace()
        {
            foreach(var bike in this.Entrants)
            {
                // Only let the bikes race if they have the ICanRace interface
                if (bike is ICanRace)
                {
                    bike.IsRacing = true;
                }
            }
        }
    }
}
