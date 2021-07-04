using System;
using Patterns.Creational.Prototype;

namespace Patterns.Runner
{
    public class PrototypeRunner : IRunner
    {
        public void Run()
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
