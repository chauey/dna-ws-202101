using Dna.CodingChallenge.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dna.CodingChallenge.Permissions
{
  public class CodingChallengePermissionDefinitionProvider : PermissionDefinitionProvider
  {
    public override void Define(IPermissionDefinitionContext context)
    {
      var codingChallegeGroup = context.AddGroup(CodingChallengePermissions.GroupName);

      //Define your own permissions here. Example:
      //myGroup.AddPermission(CodingChallengePermissions.MyPermission1, L("Permission:MyPermission1"));

      var showsPermission = codingChallegeGroup.AddPermission(CodingChallengePermissions.Shows.Default, L("Permission:Shows"));
      showsPermission.AddChild(CodingChallengePermissions.Shows.Create, L("Permission:Shows.Create"));
      showsPermission.AddChild(CodingChallengePermissions.Shows.Edit, L("Permission:Shows.Edit"));
      showsPermission.AddChild(CodingChallengePermissions.Shows.Delete, L("Permission:Shows.Delete"));
    }

    private static LocalizableString L(string name)
    {
      return LocalizableString.Create<CodingChallengeResource>(name);
    }
  }
}
