using System;

namespace Patterns.Structural.Decorator
{
    public abstract class Bike
    {
        public int WheelSize { get; set; }
        public string Color { get; set; }
        public int FrameSize { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($" - Colour: {Color}");
            Console.WriteLine($" - Wheel Size: {WheelSize}");
            Console.WriteLine($" - FrameSize: {FrameSize}");
        }
    }
}
