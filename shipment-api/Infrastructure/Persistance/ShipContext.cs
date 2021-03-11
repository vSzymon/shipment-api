using Microsoft.EntityFrameworkCore;
using shipment_api.Domain.Enitites;
using shipment_api.Interfaces;

namespace shipment_api.Infrastructure.Persistance
{
    public class ShipContext : DbContext, IShipContext
    {
        public ShipContext(DbContextOptions<ShipContext> options) : base(options)
        {
        }
        public ShipContext() : base()
        {
        }
        public DbSet<Package> Package { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShipContext).Assembly);
        }
    }
}
