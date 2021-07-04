using System;

namespace Patterns.Creational.Prototype
{
    public class BikeProductionLine
    {
        private readonly Bike _bike;
        private readonly int _totalBikes;

        public BikeProductionLine(Bike bike, int numberOfBikes)
        {
            _bike = bike;
            _totalBikes = numberOfBikes;
        }

        public void Run()
        {
            int proNumber = 1;

            Bike currentBike = _bike;

            Console.WriteLine("Building {0} number {1}", currentBike.ModelName, proNumber);

            for (int i = 1; i < _totalBikes + 1; i++)
            {
                currentBike = (Bike)currentBike.Clone();
                currentBike.ProductionNumber = proNumber + i;
                currentBike.LogBikeProuduction();
            }
        }
    }
}
