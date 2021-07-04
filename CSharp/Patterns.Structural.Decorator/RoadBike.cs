using System;

namespace Patterns.Structural.Decorator
{
    public class RoadBike : Bike
    {
        private bool HasWaterBottleCadge { get; set; }

        public override void Display()
        {
            Console.WriteLine("Road Bike");

            base.Display();

            Console.WriteLine($" - Has Water Bottle Cage: {HasWaterBottleCadge}");
        }

        public RoadBike(string colour, int wheelSize, int frameSize, bool hasWaterBottleCage)
        {
            this.FrameSize = frameSize;
            this.Color = colour;
            this.WheelSize = wheelSize;
            this.HasWaterBottleCadge = hasWaterBottleCage;
        }
    }
}
