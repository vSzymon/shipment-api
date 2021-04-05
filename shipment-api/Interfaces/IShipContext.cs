using Microsoft.EntityFrameworkCore;
using shipment_api.Domain.Enitites;
using System;

namespace shipment_api.Interfaces
{
    public interface IShipContext
    {
        public DbSet<Package> Packages { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Label> Labels { get; set; }
    }
}
