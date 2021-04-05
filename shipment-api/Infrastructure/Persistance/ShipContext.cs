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
        public DbSet<Package> Packages { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Label> Labels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShipContext).Assembly);
        }
    }
}
