using System;

namespace Patterns.Behavioral.Stratergy
{
    public class ShocksInstruction : IInstruction
    {
        public void AddComponent()
        {
            Console.WriteLine(" - Adding Shocks");
        }
    }
}
