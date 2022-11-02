using CifrasPlay.Services.Search;
using CifrasPlay.Services.Search.Entities;
using System;
using System.Threading.Tasks;

namespace CifrasPlay.Domain.Query.Search
{
    public class SearchQueryHandler
    {
        private readonly ISearchService _searchService;

        public SearchQueryHandler(ISearchService searchService)
        {
            _searchService = searchService;
        }

        public async Task<SearchQueryResponse> Handle(SearchQuery request)
        {
            try
            {
                var serviceRequest = TransformToServiceRequest(request);
                

            }
            catch
            {

            }
            return null;
        }

        public SearchDataRequest TransformToServiceRequest(SearchQuery request)
        {
            var dataRequest = new SearchDataRequest
            {
                AcessToken = request.AcessToken,
                Limit = request.Limit,
                Offset = 0,
                QueryString = request.QueryString,
                Type = request.Type,
            };
           return dataRequest;
        }
    }
}
