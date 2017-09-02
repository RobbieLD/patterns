using System;

namespace Patterns.Facade
{
    public class DicksBikeBits : IDicksBikeBits
    {
        public void GetWheels()
        {
            Console.WriteLine("Getting Loads of Wheel from Dick the wheel specialist");
        }
    }
}
