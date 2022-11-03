using CifrasPlay.Models;
using CifrasPlay.Services.Search.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CifrasPlay.Services.Search
{
    public interface ISearchService
    {
        Task<SearchData> GetSearchResponse(SearchDataRequest request);
    }
}
