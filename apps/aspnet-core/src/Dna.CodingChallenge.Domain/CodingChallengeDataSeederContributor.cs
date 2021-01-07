using CsvHelper;
using Dna.CodingChallenge.Mappers;
using Dna.CodingChallenge.Shows;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using System.Linq;
using System.IO;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using Volo.Abp.Uow;

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
      //if (await _showRepository.GetCountAsync() <= 0)
      //{
      //  await _showRepository.InsertAsync(
      //      new Show
      //      {
      //        Title = "Breaking Bad",
      //        Type = ShowType.TvShow,
      //        DateAdded = new DateTime(2010, 6, 8),
      //        Rating = RatingType.PG13
      //      },
      //      autoSave: true
      //  );

      //  await _showRepository.InsertAsync(
      //      new Show
      //      {
      //        Title = "Hobbit",
      //        Type = ShowType.Movie,
      //        DateAdded = new DateTime(2005, 1, 1),
      //        Rating = RatingType.PG
      //      },
      //      autoSave: true
      //  );
      //}

      if (await _showRepository.GetCountAsync() <= 0)
      {
        //var shows = ReadShowCSVFile(@"C:\ws\dna-ws-202101\dna-ws-202101\resources\archive - Netflix Movies and TV Shows\netflix_titles.csv");
        //var shows = ReadShowCSVFile(@"C:\ws\dna-ws-202101\dna-ws-202101\resources\archive - Netflix Movies and TV Shows\netflix_titles2.csv");
        var shows = ReadShowCSVFile("Data/netflix_titles2.csv");

        foreach (var item in shows)
        {
          // do some more stuff
          await _showRepository.InsertAsync(
                item,
                autoSave: true
            );
        }

      }
    }



    public List<Show> ReadShowCSVFile(string location)
    {
      //TextReader reader = new StreamReader("../../resources/archive - Netflix Movies and TV Shows/netflix_titles.csv");
      TextReader reader = new StreamReader(location);
      var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
      // https://didourebai.medium.com/use-csv-helper-in-net-core-4053b971ea75
      csvReader.Configuration.RegisterClassMap<ShowMap>();
      // https://stackoverflow.com/questions/31666915/how-to-use-enumconverter-with-csvhelper (old)
      // https://stackoverflow.com/questions/22762562/trouble-with-csv-helper-not-converting-bool-values (newer)
      var records = csvReader.GetRecords<Show>();

      return records.ToList();
    }

  }

}
