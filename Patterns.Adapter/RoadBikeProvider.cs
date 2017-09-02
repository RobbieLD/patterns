using System;

namespace Patterns.Adapter
{
    public class RoadBikeProvider : IRoadBikeProvider
    {
        public void AssembleBike()
        {
            Console.WriteLine(" - Assembling Bike");
        }

        public void FixBike()
        {
            Console.WriteLine(" - Fixing Bike");
        }

        public void TransferBikeToCustomer()
        {
            Console.WriteLine(" - Transfering Bike To Customer");
        }
    }
}
