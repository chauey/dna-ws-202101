using Volo.Abp.Settings;

namespace Dna.CodingChallenge.Settings
{
    public class CodingChallengeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CodingChallengeSettings.MySetting1));
        }
    }
}
