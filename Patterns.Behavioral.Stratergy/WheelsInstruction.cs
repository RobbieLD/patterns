using System;

namespace Patterns.Behavioral.Stratergy
{
    public class WheelsInstruction : IInstruction
    {
        public void AddComponent()
        {
            Console.WriteLine(" - Adding Wheels");
        }
    }
}
