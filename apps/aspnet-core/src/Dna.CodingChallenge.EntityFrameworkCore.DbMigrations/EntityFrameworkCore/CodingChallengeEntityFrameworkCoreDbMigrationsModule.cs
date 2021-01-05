using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Dna.CodingChallenge.EntityFrameworkCore
{
    [DependsOn(
        typeof(CodingChallengeEntityFrameworkCoreModule)
        )]
    public class CodingChallengeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CodingChallengeMigrationsDbContext>();
        }
    }
}
