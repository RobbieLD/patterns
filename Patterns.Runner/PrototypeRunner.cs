using System;
using Patterns.Creational.Prototype;

namespace Patterns.Runner
{
    public static class PrototypeRunner
    {
        public static void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** PROTOTYPE PATTERN ***{Environment.NewLine}");

            Bike bike = new Bike
            {
                ModelName = "Rocket",
                ProductionNumber = 1
            };

            BikeProductionLine line = new BikeProductionLine(bike, 10);

            line.Run();
            
        }
    }
}
