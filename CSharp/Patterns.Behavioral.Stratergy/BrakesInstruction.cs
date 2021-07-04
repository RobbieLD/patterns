using System;

namespace Patterns.Behavioral.Stratergy
{
    public class BrakesInstruction : IInstruction
    {
        public void AddComponent()
        {
            Console.WriteLine(" - Adding Brakes");
        }
    }
}
