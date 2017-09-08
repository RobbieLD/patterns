using System;
using Patterns.Flyweight;
using Patterns.Common;

namespace Patterns.Runner
{
    public static class FlyweightRunner
    {
        public static void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** FLYWEIGHT PATTERN ***{Environment.NewLine}");

            BikeRace race = new BikeRace();

            // Setup an array of bike types we want to use
            BikeType[] racingBikes = {
                                                   BikeType.Road,
                                                   BikeType.Mountain,
                                                   BikeType.Hybrid,
                                                   BikeType.Mountain,
                                                   BikeType.Hybrid,
                                                   BikeType.Road,
                                                   BikeType.Road,
                                                   BikeType.Mountain,
                                                   BikeType.Hybrid
                                               };

            foreach (BikeType type in racingBikes)
            {
                race.GetCompetitor(type).Ride();
            }
        }
    }
}
