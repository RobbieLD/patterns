using System;
using Patterns.Structural.Facade;

namespace Patterns.Runner
{
    public class FacadeRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

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
