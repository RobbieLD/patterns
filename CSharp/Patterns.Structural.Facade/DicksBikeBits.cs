using System;

namespace Patterns.Structural.Facade
{
    public class DicksBikeBits : IDicksBikeBits
    {
        public void GetWheels()
        {
            Console.WriteLine("Getting Loads of Wheel from Dick the wheel specialist");
        }
    }
}
