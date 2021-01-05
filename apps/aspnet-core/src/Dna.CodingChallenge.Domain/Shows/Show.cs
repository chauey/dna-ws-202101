using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Dna.CodingChallenge.Shows
{
  public class Show : AuditedAggregateRoot<int>
  {
    //public string Name { get; set; }

    //public ShowType Type { get; set; }

    //public DateTime PublishDate { get; set; }

    //public float Price { get; set; }

    //public string ShowId { get; set; }
    public ShowType Type { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public string Cast { get; set; }
    public DateTime DateAdded { get; set; }
    public int ReleaseYear { get; set; }
    public RatingType Rating { get; set; }
    public string Duration { get; set; }
    public string ListedIn { get; set; }
    public string Description { get; set; }

    //show_id,type,title,director,cast,country,date_added,
    //  release_year,rating,duration,listed_in,description

  }
}
