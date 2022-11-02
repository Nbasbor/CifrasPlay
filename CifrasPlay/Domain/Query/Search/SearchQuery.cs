using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace CifrasPlay.Domain.Query.Search
{
    /// <summary>Search query class. </summary>
    [ExcludeFromCodeCoverage]
    public class SearchQuery
    {
        /// <summary>Gets or sets the limit.</summary>
        /// <value>The limit.</value>
        [JsonProperty("limit")]
        public int Limit { get; set; }


        /// <summary>Gets or sets the query string.</summary>
        /// <value>The query string.</value>
        [JsonProperty("queryString")]
        public string QueryString { get; set; }


        /// <summary>Gets or sets the offset.</summary>
        /// <value>The offset.</value>
        [JsonProperty("offset")]
        public int Offset { get; set; }


        /// <summary>Gets or sets the acess token.</summary>
        /// <value>The acess token.</value>
        [JsonProperty("accessToken")]
        public string AcessToken { get; set; }


        /// <summary>Gets or sets the type.</summary>
        /// <value>The type.</value>
        [JsonProperty("type")]
        public List<string> Type { get; set; }

    }
}
