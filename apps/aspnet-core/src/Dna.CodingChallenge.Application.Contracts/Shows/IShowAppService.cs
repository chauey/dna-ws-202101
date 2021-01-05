

using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dna.CodingChallenge.Shows
{
  public interface IShowAppService :
      ICrudAppService< //Defines CRUD methods
      ShowDto, //Used to show books
      int, //Primary key of the book entity
      PagedAndSortedResultRequestDto, //Used for paging/sorting
      CreateUpdateShowDto> //Used to create/update a book
  {

  }
}
