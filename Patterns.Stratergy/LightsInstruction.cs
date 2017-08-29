using System;

namespace Patterns.Stratergy
{
    public class LightsInstruction : IInstruction
    {
        public void AddComponent()
        {
            Console.WriteLine(" - Adding Lights");
        }
    }
}
