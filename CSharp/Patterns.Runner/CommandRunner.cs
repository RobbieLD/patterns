using System;
using Patterns.Behavioral.Command;

namespace Patterns.Runner
{
    public class CommandRunner : BaseRunner, IRunner 
    {
        public void Run()
        {
            ShowTitle();

            BikeRider rider = new BikeRider();

            rider.Ride(BikeAction.GoForwards);
            rider.Ride(BikeAction.GoForwards);
            rider.Ride(BikeAction.TurnLeft);
            rider.Ride(BikeAction.GoForwards);
            rider.Ride(BikeAction.TurnRight);
            rider.Ride(BikeAction.GoForwards);
            rider.Ride(BikeAction.GoBackwards);

            rider.UnRide(3);

        }
    }
}
