using System;
using Patterns.Behavioral.ChainOfResponsibility;
using Patterns.Common;
using System.Collections.Generic;

namespace Patterns.Runner
{
    public class ChainOfResponsibilityRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** CHAIN OF RESPONSIBILITY PATTERN ***{Environment.NewLine}");

            // Create the links in the chain
            BikeShop mountainBikes = new MountainBikeShop("Tom's Mountain Bikes");
            BikeShop roadBikes = new RoadBikeShop("Dick's road bikes");
            BikeShop hybridBikes = new HybridBikeShop("Harry's hybrid bikes");

            // set up the chain
            mountainBikes.Successor = roadBikes;
            roadBikes.Successor = hybridBikes;

            List<BikeType> orders = new List<BikeType>
            {
                BikeType.Hybrid,
                BikeType.Mountain,
                BikeType.Road,
                BikeType.Hybrid,
                BikeType.Road,
                BikeType.Mountain
            };

            // Process the order requests

            foreach(BikeType order in orders)
            {
                mountainBikes.FillOrder(order);
            }
        }
    }
}
