using System;
using Patterns.Structural.Proxy;

namespace Patterns.Runner
{
    public class ProxyRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            IBikeStockChecker proxy = new BikeStockCheckerProxy();

            Console.WriteLine("{0} bikes", proxy.GetNumberOfMountainBikes("BigWarehouse"));
            Console.WriteLine("{0} bikes", proxy.GetNumberOfRoadBikes("GiantWarehouse"));
        }
    }
}
