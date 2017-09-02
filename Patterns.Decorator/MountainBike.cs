using System;

namespace Patterns.Decorator
{
    public class MountainBike : Bike
    {
        private int NumberOfLights { get; set; }

        public override void Display()
        {
            Console.WriteLine("Mountain Bike");

            base.Display();

            Console.WriteLine($" - Number Of Lights: {NumberOfLights}");
        }

        public MountainBike(string colour, int wheelSize, int frameSize, int numberOfLights)
        {
            this.FrameSize = frameSize;
            this.Color = colour;
            this.WheelSize = wheelSize;
            this.NumberOfLights = numberOfLights;
        }
    }
}
