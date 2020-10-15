using Demo.EntityFrameworkCore.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Demo.EntityFrameworkCore
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
         : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CityModelMapping).Assembly);
        }
    }
}