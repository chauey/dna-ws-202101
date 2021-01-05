using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Dna.CodingChallenge.Data
{
    /* This is used if database provider does't define
     * ICodingChallengeDbSchemaMigrator implementation.
     */
    public class NullCodingChallengeDbSchemaMigrator : ICodingChallengeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}