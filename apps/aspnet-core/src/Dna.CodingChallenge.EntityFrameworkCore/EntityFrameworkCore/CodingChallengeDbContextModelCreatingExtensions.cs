using Dna.CodingChallenge.Shows;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Dna.CodingChallenge.EntityFrameworkCore
{
  public static class CodingChallengeDbContextModelCreatingExtensions
  {
    public static void ConfigureCodingChallenge(this ModelBuilder builder)
    {
      Check.NotNull(builder, nameof(builder));

      /* Configure your own tables/entities inside here */

      //builder.Entity<YourEntity>(b =>
      //{
      //    b.ToTable(CodingChallengeConsts.DbTablePrefix + "YourEntities", CodingChallengeConsts.DbSchema);
      //    b.ConfigureByConvention(); //auto configure for the base class props
      //    //...
      //});

      builder.Entity<Show>(b =>
      {
        b.ToTable(CodingChallengeConsts.DbTablePrefix + "Shows", CodingChallengeConsts.DbSchema);
        b.ConfigureByConvention(); //auto configure for the base class props
        b.Property(x => x.Title).IsRequired().HasMaxLength(1024);
      });

    }
  }
}
