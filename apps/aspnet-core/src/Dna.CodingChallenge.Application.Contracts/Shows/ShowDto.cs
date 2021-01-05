using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Dna.CodingChallenge.Shows
{
  public class ShowDto : AuditedEntityDto<int>
  {
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

  }
}
