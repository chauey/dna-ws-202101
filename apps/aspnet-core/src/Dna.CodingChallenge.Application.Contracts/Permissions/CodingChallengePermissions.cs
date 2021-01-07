namespace Dna.CodingChallenge.Permissions
{
    public static class CodingChallengePermissions
    {
        public const string GroupName = "CodingChallenge";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public static class Shows
    {
      public const string Default = GroupName + ".Shows";
      public const string Create = Default + ".Create";
      public const string Edit = Default + ".Edit";
      public const string Delete = Default + ".Delete";
    }
  }
}
