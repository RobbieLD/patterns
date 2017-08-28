using System;

namespace Patterns.Decorator
{
    public class Shocks : Decorator
    {
        private int ShockTravel { get; set; }

        public Shocks(Bike bike) 
            : base(bike)
        {
        }

        public void AddShocks(int travel)
        {
            ShockTravel = travel;

            // If this bike gets shocks the wheel size must be 26
            _bike.WheelSize = 26;
        }

        public override void Display()
        {
            base.Display();

            Console.WriteLine($" - Shock Travel: {ShockTravel}");
        }
    }
}
