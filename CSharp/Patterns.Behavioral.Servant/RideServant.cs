using System;

namespace Patterns.Behavioral.Servant
{
    public class RideServant
    {
        public void RideTo(IBike bike, int direction, int distance)
        {
            // Calculate the new x and y coords 
            double angle = Math.PI * direction / 180.0;
            double x = (Math.Sin(angle) * distance);
            double y = (Math.Cos(angle) * distance);

            var newPosition = new CoordinatePair(Math.Round(bike.Position.X + x, 2), Math.Round(bike.Position.Y + y, 2));

            // Calculate the new time
            bike.Time = bike.Time.AddHours(bike.Speed * distance);
            bike.SetPosition(newPosition);
        }
    }
}
