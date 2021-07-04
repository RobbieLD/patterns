using System;

namespace Patterns.Structural.Facade
{
    public class HarrysJunkYard : IHarrysJunkYard
    {
        public void GetBrakes()
        {
            Console.WriteLine("Getting Cheap from Harry's Warehouse");
        }

        public void GetShocks()
        {
            Console.WriteLine("Getting Cheap Shocks from Harry's Warehouse");
        }
    }
}
