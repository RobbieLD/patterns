using System;
using Patterns.Structural.Adapter;
using System.Collections.Generic;

namespace Patterns.Runner
{
    public class AdapterRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** ADAPTER PATTERN ***{Environment.NewLine}");

            // Make a list of all the different adapters we have, each containing their own provider
            // which they are adapter

            List<IBikeProvider> providers = new List<IBikeProvider>
            {
                new RoadBikeProviderAdapter(new RoadBikeProvider()),
                new MountainBikeProviderAdapter(new MountainBikeProvider())
            };

            foreach(IBikeProvider p in providers)
            {
                Console.WriteLine($"Executing methods from {p.GetType().Name}");
                p.CreateBike();
                p.ReloadBike();
                p.TransferBike();
            }            
        }
    }
}
