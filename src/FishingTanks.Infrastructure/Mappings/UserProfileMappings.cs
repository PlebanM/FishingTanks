using FishingTanks.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FishingTanks.Infrastructure.Mappings
{
    public class UserProfileMappings : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.PESEL)
                .HasMaxLength(11);

            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasColumnType("varchar(30)");
            
            builder.Property(c => c.LastName)
                .IsRequired()
                .HasColumnType("varchar(60)");
            

            builder.HasMany(c => c.Licenses)
                .WithOne(b => b.UserProfile)
                .HasForeignKey(b => b.Id);

            builder.ToTable("UserProfiles");
        }
    }
}