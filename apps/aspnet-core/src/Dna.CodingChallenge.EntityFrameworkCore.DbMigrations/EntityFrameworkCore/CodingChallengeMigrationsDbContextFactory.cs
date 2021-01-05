using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Dna.CodingChallenge.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class CodingChallengeMigrationsDbContextFactory : IDesignTimeDbContextFactory<CodingChallengeMigrationsDbContext>
    {
        public CodingChallengeMigrationsDbContext CreateDbContext(string[] args)
        {
            CodingChallengeEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<CodingChallengeMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new CodingChallengeMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Dna.CodingChallenge.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
