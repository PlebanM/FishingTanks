using System.Linq;
using FishingTanks.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FishingTanks.Infrastructure.Context
{
    public class FishingTanksDbContext : DbContext
    {
        public FishingTanksDbContext(DbContextOptions<FishingTanksDbContext> options) : base(options)
        {
        }
        
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Licens> Licenses { get; set; }
        
    }
}