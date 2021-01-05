using Volo.Abp.Modularity;

namespace Dna.CodingChallenge
{
    [DependsOn(
        typeof(CodingChallengeApplicationModule),
        typeof(CodingChallengeDomainTestModule)
        )]
    public class CodingChallengeApplicationTestModule : AbpModule
    {

    }
}