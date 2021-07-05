using System;
using Patterns.Behavioral.Iterator;

namespace Patterns.Runner
{
    public class IteratorRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            BikeProductionLine productionLine = new BikeProductionLine(new Bike
            {
                ProductionNumber = 1
            });

            productionLine.Add(new Bike
            {
                ProductionNumber = 2
            });

            productionLine.Add(new Bike
            {
                ProductionNumber = 3
            });

            productionLine.Add(new Bike
            {
                ProductionNumber = 4
            });

            BikeIterator iterator = productionLine.CreateIterator();

            while(!iterator.IsFinished)
            {
                iterator.CurrentBike.Build();
                iterator.Next();
            }
        }
    }
}
