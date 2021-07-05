using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Patterns.Behavioral.Specification;
using System;
using System.Collections.Generic;

namespace Patterns.Runner
{
    public class SpecificationRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            // Setup the services we need for the DI.
            IServiceProvider serviceProvider = new ServiceCollection()
                .AddScoped<BikeShop>()
                .AddScoped<IRepository<Bike>, Warehouse>()
                .AddDbContext<BikeShopContext>(options => options.UseInMemoryDatabase("bikes"))
                .BuildServiceProvider();

            CreateData();

            var bikeShop = serviceProvider.GetService<BikeShop>();

            foreach(Bike bike in bikeShop.GetChildrensBikes())
            {
                Console.WriteLine(bike.ToString());
            }
        }

        private static void CreateData()
        {
            var builder = new DbContextOptionsBuilder<BikeShopContext>();

            builder.UseInMemoryDatabase("bikes");
            var options = builder.Options;

            using var context = new BikeShopContext(options);
            var bikes = new List<Bike>
                {
                    new Bike(12, 3, BikeType.MountainBike, "Blue"),
                    new Bike(15, 4, BikeType.RoadBike, "Red"),
                    new Bike(10, 5, BikeType.HybridBike, "Yellow"),
                    new Bike(20, 10, BikeType.HybridBike, "Green"),
                    new Bike(18, 12, BikeType.HybridBike, "Black")
                };

            context.AddRange(bikes);
            context.SaveChanges();
        }
    }
}
