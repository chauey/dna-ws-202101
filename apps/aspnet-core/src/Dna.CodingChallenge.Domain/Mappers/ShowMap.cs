using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using Dna.CodingChallenge.Shows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dna.CodingChallenge.Mappers
{
  public sealed class ShowMap : ClassMap<Show>
  {
    public ShowMap()
    {
      // show_id,type,title,director,cast,country,date_added,
      // release_year,rating,duration,listed_in,description
      // TODO: EnumConverter enumConverter = new EnumConverter(typeof(ShowType));
      Map(x => x.Title).Name("title");
      Map(x => x.Director).Name("director");
      Map(x => x.Cast).Name("cast");
      Map(x => x.DateAdded).Name("date_added");
      Map(x => x.ReleaseYear).Name("release_year");
      Map(x => x.Rating).Name("rating");
      Map(x => x.Duration).Name("duration");
      Map(x => x.ListedIn).Name("listed_in");
      Map(x => x.Description).Name("description");
      Map(m => m.Type).Name("type");
    }
  }
}
