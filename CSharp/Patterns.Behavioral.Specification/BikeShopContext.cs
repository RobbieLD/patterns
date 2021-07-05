using Microsoft.EntityFrameworkCore;

namespace Patterns.Behavioral.Specification
{
    public class BikeShopContext : DbContext
    {
        // This one is needed for Moq
        public BikeShopContext()
        { }

        public BikeShopContext(DbContextOptions<BikeShopContext> options)
                : base(options)
        { }

        public virtual DbSet<Bike> Bikes { get; set; }
    }
}
