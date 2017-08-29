using System;

namespace Patterns.Stratergy
{
    public class ShocksInstruction : IInstruction
    {
        public void AddComponent()
        {
            Console.WriteLine(" - Adding Shocks");
        }
    }
}
