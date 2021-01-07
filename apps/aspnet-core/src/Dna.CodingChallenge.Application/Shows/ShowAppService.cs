

using Dna.CodingChallenge.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dna.CodingChallenge.Shows
{
  public class ShowAppService :
      CrudAppService<
          Show, //The Book entity
          ShowDto, //Used to show books
          int, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateShowDto>, //Used to create/update a book
      IShowAppService //implement the IBookAppService
  {
    public ShowAppService(IRepository<Show, int> repository)
        : base(repository)
    {
      GetPolicyName = CodingChallengePermissions.Shows.Default;
      GetListPolicyName = CodingChallengePermissions.Shows.Default;
      CreatePolicyName = CodingChallengePermissions.Shows.Create;
      UpdatePolicyName = CodingChallengePermissions.Shows.Edit;
      DeletePolicyName = CodingChallengePermissions.Shows.Delete;
    }
  }
}
