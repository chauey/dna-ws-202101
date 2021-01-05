using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Dna.CodingChallenge
{
    [Dependency(ReplaceServices = true)]
    public class CodingChallengeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CodingChallenge";
    }
}
