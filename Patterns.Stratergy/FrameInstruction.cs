using System;

namespace Patterns.Stratergy
{
    public class FrameInstruction : IInstruction
    {
        public void AddComponent()
        {
            Console.WriteLine(" - Adding Frame");
        }
    }
}
