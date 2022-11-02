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
        Task<SearchData> GetSearchResponse(string query, string[] type, int limit, string countryCode, int offset, string accessToken);
    }
}
