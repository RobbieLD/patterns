using System;
using Patterns.Behavioral.Command;

namespace Patterns.Runner
{
    public static class CommandRunner
    {
        public static void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** COMMAND PATTERN ***{Environment.NewLine}");

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
