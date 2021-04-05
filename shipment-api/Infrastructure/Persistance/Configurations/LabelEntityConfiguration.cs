using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shipment_api.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shipment_api.Infrastructure.Persistance.Configurations
{
    public class LabelEntityConfiguration : IEntityTypeConfiguration<Label>
    {
        public void Configure(EntityTypeBuilder<Label> builder)
        {
            builder.Property(prop => prop.LabelId).HasColumnName("Id");
            builder.Property(prop => prop.Image).HasColumnName("Image");
           
            builder.Property(prop => prop.ImageFileType).HasColumnName("FileType");
           
            builder.HasOne(label => label.Package)
                .WithOne(pack => pack.Label)
                .HasForeignKey<Package>(pack => pack.LabelId)
                .HasConstraintName("FK_packages_labels");
        }
    }
}
