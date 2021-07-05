using System;
using Patterns.Creational.Prototype;

namespace Patterns.Runner
{
    public class PrototypeRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

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
