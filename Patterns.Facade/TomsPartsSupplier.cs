using System;

namespace Patterns.Facade
{
    public class TomsPartsSupplier : ITomsPartsSupplier
    {
        public void GetBrakes()
        {
            Console.WriteLine("Getting Brakes from Tom's Warehouse");
        }

        public void GetWheels()
        {
            Console.WriteLine("Getting Wheels from Tom's Warehouse");
        }

        public void GetShocks()
        {
            throw new NotImplementedException("We Don't Sell Shocks");
        }
    }
}
