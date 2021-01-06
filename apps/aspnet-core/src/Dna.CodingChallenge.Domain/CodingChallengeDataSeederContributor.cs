using Dna.CodingChallenge.Shows;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Dna.CodingChallenge
{
  public class CodingChallengeDataSeederContributor
      : IDataSeedContributor, ITransientDependency
  {
    private readonly IRepository<Show, int> _showRepository;

    public CodingChallengeDataSeederContributor(IRepository<Show, int> showRepository)
    {
      _showRepository = showRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
      if (await _showRepository.GetCountAsync() <= 0)
      {
        await _showRepository.InsertAsync(
            new Show
            {
              Title = "Breaking Bad",
              Type = ShowType.TvShow,
              DateAdded = new DateTime(2010, 6, 8),
              Rating = RatingType.PG13
            },
            autoSave: true
        );

        await _showRepository.InsertAsync(
            new Show
            {
              Title = "Hobbit",
              Type = ShowType.Movie,
              DateAdded = new DateTime(2005, 1, 1),
              Rating = RatingType.PG
            },
            autoSave: true
        );
      }
    }
  }
}
