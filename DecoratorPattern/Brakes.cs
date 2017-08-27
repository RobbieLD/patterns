using System;

namespace Patterns.Decorator
{
    public class Brakes : Decorator
    {
        private BrakeType BrakeType { get; set; }

        public Brakes(Bike bike) :
            base(bike)
        {
        }

        public void AddBrakes(BrakeType type)
        {
            BrakeType = type;
        }

        public override void Display()
        {
            base.Display();

            Console.WriteLine($" - Brake Type: {BrakeType}");
        }
    }
}
