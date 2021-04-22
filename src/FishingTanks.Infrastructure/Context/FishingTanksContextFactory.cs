using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FishingTanks.Infrastructure.Context
{
    public class FishingTanksContextFactory : IDesignTimeDbContextFactory<FishingTanksDbContext>
    {
        public FishingTanksDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FishingTanksDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=pftdb;User Id=SA;Password=Admin666666;MultipleActiveResultSets=true");

            return new FishingTanksDbContext(optionsBuilder.Options);
        }
    }
}