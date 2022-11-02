using System.Collections.Generic;

namespace CifrasPlay.Domain.Query.Search
{
    public class SearchQueryResponse
    {
        /// <summary>Gets or sets the artists.</summary>
        /// <value>The artists.</value>
        public List<ArtistResponse> Artists { get; set; }

        /// <summary>Gets or sets the albums.</summary>
        /// <value>The albums.</value>
        public List<AlbumResponse> Albums { get; set; }

        /// <summary>Gets or sets the tracks.</summary>
        /// <value>The tracks.</value>
        public List<TrackResponse> Tracks { get; set; }

        /// <summary>Gets or sets the playlists.</summary>
        /// <value>The playlists.</value>
        public List<PlaylistResponse> Playlists { get; set; }

    }

    /// <summary>Album response class.</summary>
    public class AlbumResponse
    {
        /// <summary>Gets or sets the type of the album.</summary>
        /// <value>The type of the album.</value>
        public string AlbumType { get; set; }

        /// <summary>Gets or sets the artists.</summary>
        /// <value>The artists.</value>
        public List<ArtistResponse> Artists { get; set; }

        /// <summary>Gets or sets the characteristcs.</summary>
        /// <value>The characteristcs.</value>
        public Characteristics Characteristcs { get; set; }

        /// <summary>Gets or sets the release date.</summary>
        /// <value>The release date.</value>
        public string ReleaseDate { get; set; }

        /// <summary>Gets or sets the total album tracks.</summary>
        /// <value>The total album tracks.</value>
        public int TotalAlbumTracks { get; set; }

        /// <summary>Gets or sets the images.</summary>
        /// <value>The images.</value>
        public List<ImageResponse> Images { get; set; }
    }

    /// <summary>Track reponse class.</summary>
    public class TrackResponse
    {
        /// <summary>Gets or sets the album.</summary>
        /// <value>The album.</value>
        public AlbumResponse Album { get; set; }

        /// <summary>Gets or sets the artists.</summary>
        /// <value>The artists.</value>
        public List<ArtistResponse> Artists { get; set; }

        /// <summary>Gets or sets the characteristcs.</summary>
        /// <value>The characteristcs.</value>
        public Characteristics Characteristcs { get; set; }

        /// <summary>Gets or sets the external ids.</summary>
        /// <value>The external ids.</value>
        public string ExternalIds { get; set; }

        /// <summary>Gets or sets the track number.</summary>
        /// <value>The track number.</value>
        public int TrackNumber { get; set; }

        /// <summary>Gets or sets the disc track number.</summary>
        /// <value>The disc track number.</value>
        public int DiscTrackNumber { get; set; }

        /// <summary>Gets or sets the duration track.</summary>
        /// <value>The duration track.</value>
        public int DurationTrack { get; set; }

        /// <summary>Gets or sets a value indicating whether [explicit track].</summary>
        /// <value><c>true</c> if [explicit track]; otherwise, <c>false</c>.</value>
        public bool ExplicitTrack { get; set; }

        /// <summary>Gets or sets a value indicating whether this instance is local.</summary>
        /// <value><c>true</c> if this instance is local; otherwise, <c>false</c>.</value>
        public bool IsLocal { get; set; }

        /// <summary>Gets or sets the preview URL.</summary>
        /// <value>The preview URL.</value>
        public string PreviewUrl { get; set; }
    }

    /// <summary>Playlist reponse class.</summary>
    public class PlaylistResponse
    {
    }

    /// <summary>Artist Response class.</summary>
    public class ArtistResponse
    {
        /// <summary>Gets or sets the characteristcs.</summary>
        /// <value>The characteristcs.</value>
        public Characteristics Characteristcs { get; set; }

        /// <summary>Gets or sets the followers.</summary>
        /// <value>The followers.</value>
        public int Followers { get; set; }

        /// <summary>Gets or sets the genres.</summary>
        /// <value>The genres.</value>
        public List<string> Genres { get; set; }

        /// <summary>Gets or sets the images.</summary>
        /// <value>The images.</value>
        public List<ImageResponse> Images { get; set; }
    }

    /// <summary>Image response class. </summary>
    public class ImageResponse
    {
        /// <summary>Gets or sets the URL.</summary>
        /// <value>The URL.</value>
        public string Url { get; set; }
    }

    /// <summary>Characteristics class</summary>
    public class Characteristics
    {
        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>Gets or sets the popularity.</summary>
        /// <value>The popularity.</value>
        public int Popularity { get; set; }

        /// <summary>Gets or sets the type.</summary>
        /// <value>The type.</value>
        public string Type { get; set; }

        /// <summary>Gets or sets the URI.</summary>
        /// <value>The URI.</value>
        public string Uri { get; set; }

        /// <summary>Gets or sets the available markets.</summary>
        /// <value>The available markets.</value>
        public List<string> AvailableMarkets { get; set; }

        /// <summary>Gets or sets the external urls.</summary>
        /// <value>The external urls.</value>
        public string ExternalUrls { get; set; }

        /// <summary>Gets or sets the href.</summary>
        /// <value>The href.</value>
        public string Href { get; set; }

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }
    }
}
