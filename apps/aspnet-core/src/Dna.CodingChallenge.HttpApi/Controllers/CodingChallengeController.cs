using Dna.CodingChallenge.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dna.CodingChallenge.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CodingChallengeController : AbpController
    {
        protected CodingChallengeController()
        {
            LocalizationResource = typeof(CodingChallengeResource);
        }
    }
}