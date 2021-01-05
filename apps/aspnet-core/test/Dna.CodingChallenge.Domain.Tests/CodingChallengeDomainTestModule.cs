using Dna.CodingChallenge.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dna.CodingChallenge
{
    [DependsOn(
        typeof(CodingChallengeEntityFrameworkCoreTestModule)
        )]
    public class CodingChallengeDomainTestModule : AbpModule
    {

    }
}