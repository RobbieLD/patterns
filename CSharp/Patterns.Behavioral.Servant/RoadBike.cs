
using System;

namespace Patterns.Behavioral.Servant
{
    public class RoadBike : IBike
    {
        public RoadBike()
        {
            this.Position = new CoordinatePair(0, 0);
            this.Time = DateTime.Now;
        }

        public CoordinatePair Position { get; private set; }

        public int Speed => 50;

        public DateTime Time { get; set; }

        public void SetPosition(CoordinatePair coordinates)
        {
            this.Position = coordinates;
        }

        public override string ToString()
        {
            return string.Format("Position: {0} at {1}", this.Position.ToString(), this.Time.ToShortTimeString());
        }
    }
}
