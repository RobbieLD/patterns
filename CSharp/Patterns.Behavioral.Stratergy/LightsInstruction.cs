using System;

namespace Patterns.Behavioral.Stratergy
{
    public class LightsInstruction : IInstruction
    {
        public void AddComponent()
        {
            Console.WriteLine(" - Adding Lights");
        }
    }
}
