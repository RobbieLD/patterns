using System;
using Patterns.Structural.Facade;

namespace Patterns.Runner
{
    public static class FacadeRunner
    {
        public static void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** FACADE PATTERN ***{Environment.NewLine}");

            // Make the various part suppliers
            TomsPartsSupplier tom = new TomsPartsSupplier();
            DicksBikeBits dick = new DicksBikeBits();
            HarrysJunkYard harry = new HarrysJunkYard();

            IPartsSupplier supplier = new PartsSupplier(tom, dick, harry);

            supplier.GetBrakes();
            supplier.GetWheels();
            supplier.GetShocks();
        }
    }
}
