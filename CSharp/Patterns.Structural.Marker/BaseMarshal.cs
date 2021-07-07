
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Marker
{
    public abstract class BaseMarshal
    {
        protected IEnumerable<Bike> Entrants { get; }

        public BaseMarshal(IEnumerable<Bike> entrants)
        {
            this.Entrants = entrants;
        }

        public abstract void StartRace();

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            foreach (var bike in this.Entrants)
            {
                stringBuilder.AppendLine($"{bike.GetType().Name}, Racing:{bike.IsRacing}");
            }

            return stringBuilder.ToString();
        }
    }
}
