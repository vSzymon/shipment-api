using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shipment_api.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shipment_api.Infrastructure.Persistance.Configurations
{
    public class PackageEntityConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.Property(prop => prop.PackageId).HasColumnName("Id");
            builder.Property(prop => prop.TrackingNumber)
                .HasColumnName("TrackingNumber")
                .HasMaxLength(36);
           
            builder.Property(prop => prop.Created).HasColumnName("Created");
            builder.Property(prop => prop.Shipped).HasColumnName("Shipped");
            builder.Property(prop => prop.CustomerId).HasColumnName("CustomerId");
            builder.Property(prop => prop.ShipperId).HasColumnName("ShipperId");
            builder.Property(prop => prop.LabelId).HasColumnName("LabelId");

            builder.HasMany(pack => pack.Products)
                .WithOne(prod => prod.Package)
                .HasForeignKey(prod => prod.PackageId)
                .HasConstraintName("FK_packages_products");
           
            builder.HasOne(pack => pack.Label)
                .WithOne(lab => lab.Package)
                .HasForeignKey<Label>(pack => pack.LabelId)
                .HasConstraintName("FK_packages_labels");
          
            builder.HasOne(pack => pack.Customer)
                .WithMany(customer => customer.Packages)
                .HasForeignKey(pack => pack.CustomerId)
                .HasConstraintName("FK_packages_customers");

            builder.HasOne(pack => pack.Shipper)
                .WithMany(shipper => shipper.Packages)
                .HasForeignKey(pack => pack.ShipperId)
                .HasForeignKey("FK_packages_shippers");
                
        }
    }
}
