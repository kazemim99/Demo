using Demo.Core.Configuration.Wedjoo.Configuration;
using Demo.Core.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

namespace Demo.EntityFrameworkCore
{
    public static class DemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection.ConnectionString);
        }
    }

    public class DemoDbContextFactory : IDesignTimeDbContextFactory<DemoDbContext>
    {
        public DemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DemoDbContext>();
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            DemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString("Default"));

            return new DemoDbContext(builder.Options);
        }
    }
}