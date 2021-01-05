using AutoMapper;
using Dna.CodingChallenge.Shows;

namespace Dna.CodingChallenge
{
  public class CodingChallengeApplicationAutoMapperProfile : Profile
  {
    public CodingChallengeApplicationAutoMapperProfile()
    {
      /* You can configure your AutoMapper mapping configuration here.
       * Alternatively, you can split your mapping configurations
       * into multiple profile classes for a better organization. */
      CreateMap<Show, ShowDto>();
      CreateMap<CreateUpdateShowDto, Show>();
    }
  }
}
