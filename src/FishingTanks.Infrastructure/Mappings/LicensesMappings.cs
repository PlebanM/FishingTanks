using System;
using FishingTanks.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FishingTanks.Infrastructure.Mappings
{
    public class LicensesMappings : IEntityTypeConfiguration<Licens>
    {
        public void Configure(EntityTypeBuilder<Licens> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar(150)");
            
            builder.Property(x => x.Description)
                .HasColumnType("varchar(400)");

            builder.Property(x => x.CreateDate)
                .IsRequired()
                .HasDefaultValue(DateTimeOffset.Now);
            
            builder.ToTable("Licenses");
        }
    }
}