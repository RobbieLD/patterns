using Patterns.Behavioral.State;
using System;

namespace Patterns.Runner
{
    public class StateRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** STATE PATTERN ***{Environment.NewLine}");

            Bike bike = new Bike("Rob");

            // Road Bike
            bike.Display();

            // Hybrid Bike
            bike.Add(ComponentType.Shocks);
            bike.Display();

            // Mountain Bike
            bike.Add(ComponentType.DiscBrakes);
            bike.Display();

            // Road Bike
            bike.Remove(ComponentType.DiscBrakes);
            bike.Remove(ComponentType.Shocks);
            bike.Display();
        }
    }
}
