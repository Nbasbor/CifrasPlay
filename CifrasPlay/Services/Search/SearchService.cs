using CifrasPlay.Models;
using CifrasPlay.Services.Search.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace CifrasPlay.Services.Search
{
    public class SearchService : ISearchService
    {
       
    
        private readonly HttpClient _httpClient;

        public SearchService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<SearchData> GetSearchResponse(SearchDataRequest request)
        {

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", request.AccessToken);

            var response = await _httpClient.GetAsync($"search?q={request.QueryString}&type={request.Type}market={request.CountryCode}&limit={request.Limit}&offset={request.Offset}");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<SearchData>(responseStream);

            return responseObject;
        }
    }
}
