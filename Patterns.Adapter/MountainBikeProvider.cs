using System;

namespace Patterns.Adapter
{
    public class MountainBikeProvider : IMountainBikeProvider
    {
        public void BuildBike()
        {
            Console.WriteLine(" - Building Bike");
        }

        public void RepairBike()
        {
            Console.WriteLine(" - Repairing Bike");
        }

        public void SellBike()
        {
            Console.WriteLine(" - Selling Bike");
        }
    }
}
