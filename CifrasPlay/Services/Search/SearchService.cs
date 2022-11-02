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
        public async Task<SearchData> GetSearchResponse(string query, string[] type, int limit, string countryCode, int offset, string accessToken)
        {

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var response = await _httpClient.GetAsync($"search?q={query}&type={type}market={countryCode}&limit={limit}&offset={offset}");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<SearchData>(responseStream);

            return responseObject;
        }
    }
}
