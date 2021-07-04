using System;
using Patterns.Structural.Proxy;

namespace Patterns.Runner
{
    public class ProxyRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** PROXY PATTERN ***{Environment.NewLine}");

            IBikeStockChecker proxy = new BikeStockCheckerProxy();

            Console.WriteLine("{0} bikes", proxy.GetNumberOfMountainBikes("BigWarehouse"));
            Console.WriteLine("{0} bikes", proxy.GetNumberOfRoadBikes("GiantWarehouse"));
        }
    }
}
