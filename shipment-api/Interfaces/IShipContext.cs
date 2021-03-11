using Microsoft.EntityFrameworkCore;
using shipment_api.Domain.Enitites;
using System;

namespace shipment_api.Interfaces
{
    public interface IShipContext
    {
        public DbSet<Package> Package { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
