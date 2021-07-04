using System;

namespace Patterns.Behavioral.Stratergy
{
    public class FrameInstruction : IInstruction
    {
        public void AddComponent()
        {
            Console.WriteLine(" - Adding Frame");
        }
    }
}
