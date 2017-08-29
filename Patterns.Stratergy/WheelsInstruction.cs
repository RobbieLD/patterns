using System;

namespace Patterns.Stratergy
{
    public class WheelsInstruction : IInstruction
    {
        public void AddComponent()
        {
            Console.WriteLine(" - Adding Wheels");
        }
    }
}
