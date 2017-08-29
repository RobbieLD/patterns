using System;

namespace Patterns.Stratergy
{
    public class BrakesInstruction : IInstruction
    {
        public void AddComponent()
        {
            Console.WriteLine(" - Adding Brakes");
        }
    }
}
