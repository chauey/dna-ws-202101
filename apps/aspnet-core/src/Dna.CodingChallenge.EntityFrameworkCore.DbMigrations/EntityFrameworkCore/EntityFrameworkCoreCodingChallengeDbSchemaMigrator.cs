using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dna.CodingChallenge.Data;
using Volo.Abp.DependencyInjection;

namespace Dna.CodingChallenge.EntityFrameworkCore
{
    public class EntityFrameworkCoreCodingChallengeDbSchemaMigrator
        : ICodingChallengeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCodingChallengeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CodingChallengeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CodingChallengeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}