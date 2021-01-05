
using System;
using System.ComponentModel.DataAnnotations;

namespace Dna.CodingChallenge.Shows
{
  public class CreateUpdateShowDto
  {
    public ShowType Type { get; set; }

    [Required]
    [StringLength(1024)]
    public string Title { get; set; }
    public string Director { get; set; }
    public string Cast { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateAdded { get; set; }
    public int ReleaseYear { get; set; }
    public RatingType Rating { get; set; }
    public string Duration { get; set; }
    public string ListedIn { get; set; }
    public string Description { get; set; }
  }
}
