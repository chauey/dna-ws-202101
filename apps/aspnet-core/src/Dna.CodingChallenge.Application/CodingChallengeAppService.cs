using System;
using System.Collections.Generic;
using System.Text;
using Dna.CodingChallenge.Localization;
using Volo.Abp.Application.Services;

namespace Dna.CodingChallenge
{
    /* Inherit your application services from this class.
     */
    public abstract class CodingChallengeAppService : ApplicationService
    {
        protected CodingChallengeAppService()
        {
            LocalizationResource = typeof(CodingChallengeResource);
        }
    }
}
