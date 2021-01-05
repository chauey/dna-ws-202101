using Dna.CodingChallenge.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dna.CodingChallenge.Permissions
{
    public class CodingChallengePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CodingChallengePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CodingChallengePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CodingChallengeResource>(name);
        }
    }
}
