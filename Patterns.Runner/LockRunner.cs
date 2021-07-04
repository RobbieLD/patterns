using Patterns.Concurrency.Lock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Runner
{
    public class LockRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}*** LOCK PATTERN ***{Environment.NewLine}");

            var warehouse = new Warehouse(2);

            var FredsBikes = new BikeShop(warehouse);
            var BillsBikes = new BikeShop(warehouse);
            var JimsBikes = new BikeShop(warehouse);

            List<Task> tasks = new();

            Console.WriteLine(string.Format("Warehouse Stock Level: {0}", warehouse.CheckStock()));

            tasks.Add(Task.Factory.StartNew(() => FredsBikes.SellBike()));
            tasks.Add(Task.Factory.StartNew(() => BillsBikes.SellBike()));
            tasks.Add(Task.Factory.StartNew(() => FredsBikes.SellBike()));
            tasks.Add(Task.Factory.StartNew(() => FredsBikes.SellBike()));
            tasks.Add(Task.Factory.StartNew(() => JimsBikes.SellBike()));
            tasks.Add(Task.Factory.StartNew(() => JimsBikes.SellBike()));
            tasks.Add(Task.Factory.StartNew(() => FredsBikes.SellBike()));
            tasks.Add(Task.Factory.StartNew(() => BillsBikes.SellBike()));
            tasks.Add(Task.Factory.StartNew(() => FredsBikes.SellBike()));
            tasks.Add(Task.Factory.StartNew(() => BillsBikes.SellBike()));

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine(string.Format("Warehouse Stock Level: {0}", warehouse.CheckStock()));
        }
    }
}
