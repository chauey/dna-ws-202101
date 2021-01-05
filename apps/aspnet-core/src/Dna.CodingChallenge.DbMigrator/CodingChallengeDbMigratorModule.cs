using Dna.CodingChallenge.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Dna.CodingChallenge.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CodingChallengeEntityFrameworkCoreDbMigrationsModule),
        typeof(CodingChallengeApplicationContractsModule)
        )]
    public class CodingChallengeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
