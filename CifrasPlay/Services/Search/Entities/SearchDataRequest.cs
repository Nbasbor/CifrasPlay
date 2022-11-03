using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace CifrasPlay.Services.Search.Entities
{
    [ExcludeFromCodeCoverage]
    public class SearchDataRequest
    {
        /// <summary>Gets or sets the limit.</summary>
        /// <value>The limit.</value>
        [JsonProperty("limit")]
        public int Limit { get; set; }


        /// <summary>Gets or sets the query string.</summary>
        /// <value>The query string.</value>
        [JsonProperty("queryString")]
        public string QueryString { get; set; }


        /// <summary>Gets or sets the country code.</summary>
        /// <value>The country code.</value>
        [JsonProperty("coutryCode")]
        public string CountryCode { get; set; }


        /// <summary>Gets or sets the offset.</summary>
        /// <value>The offset.</value>
        [JsonProperty("offset")]
        public int Offset { get; set; }


        /// <summary>Gets or sets the acess token.</summary>
        /// <value>The acess token.</value>
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }


        /// <summary>Gets or sets the type.</summary>
        /// <value>The type.</value>
        [JsonProperty("type")]
        public List<string> Type { get; set; }

    }
}
