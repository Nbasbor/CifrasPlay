using CifrasPlay.Services.Search;
using CifrasPlay.Services.Search.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CifrasPlay.Domain.Query.Search
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchQueryHandler
    {
        /// <summary>The search service</summary>
        private readonly ISearchService _searchService;

        /// <summary>Initializes a new instance of the <see cref="SearchQueryHandler"/> class.</summary>
        /// <param name="searchService">The search service.</param>
        public SearchQueryHandler(ISearchService searchService)
        {
            _searchService = searchService;
        }

        /// <summary>Handles the specified request.</summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<SearchQueryResponse> Handle(SearchQuery request)
        {
            try
            {
                var serviceRequest = TransformRequest(request);
                var result = await _searchService.GetSearchResponse(serviceRequest);
                var albums = result?.albums?.items;
                var artist = result?.artists?.items;
                var tracks = result?.tracks?.items;
                var domainResponse = new SearchQueryResponse
                {
                    Albums = new List<AlbumResponse>()
                    {
                        GetAlbumsList(albums.FirstOrDefault())
                    },
                    Artists = new List<ArtistResponse>()
                    {
                        GetArtistsList(artist)
                    },
                    Tracks = new List<TrackResponse>()
                    { 
                        GetTracksList(tracks)
                    }

                };
                return domainResponse;
            }
            catch
            {

            }
            finally
            {

            }
            return null;
        }

        /// <summary>Gets the tracks list.</summary>
        /// <param name="tracks">The tracks.</param>
        /// <returns></returns>
        private static TrackResponse GetTracksList(TrackItem[] tracks)
        {
            var tracksAlbums = tracks.FirstOrDefault().album;
            return new TrackResponse()
            {
                Album = GetAlbumsList(tracksAlbums),
                Characteristcs = new Characteristics
                {
                    ExternalUrls = tracks.FirstOrDefault().external_urls.spotify,
                    Id = tracks.FirstOrDefault().id,
                    Name = tracks.FirstOrDefault().name,
                    Uri = tracks.FirstOrDefault().uri,
                    Type = tracks.FirstOrDefault().type,
                    AvailableMarkets = new List<string>
                    {
                        tracks.FirstOrDefault().available_markets.FirstOrDefault()
                    },
                },
                DurationTrack = tracks.FirstOrDefault().duration_ms,
                ExplicitTrack = tracks.FirstOrDefault()._explicit
            };
        }

        /// <summary>Gets the artists list.</summary>
        /// <param name="artist">The artist.</param>
        /// <returns></returns>
        private static ArtistResponse GetArtistsList(Artist[] artist)
        {
            return new ArtistResponse()
            {
                Followers = artist.FirstOrDefault().followers.total,
                Genres = new List<string> { artist.FirstOrDefault().genres.FirstOrDefault() },
                Images = new List<ImageResponse>
                {
                    new ImageResponse
                    {
                        Url = artist.FirstOrDefault().images.FirstOrDefault().url,
                    }
                },
                Characteristcs = new Characteristics
                {
                    ExternalUrls = artist.FirstOrDefault().external_urls.spotify,
                    Id = artist.FirstOrDefault().id,
                    Name = artist.FirstOrDefault().name,
                    Uri = artist.FirstOrDefault().uri,
                    Type = artist.FirstOrDefault().type
                },
            };
        }

        /// <summary>Gets the albums list.</summary>
        /// <param name="albums">The albums.</param>
        /// <returns></returns>
        private static AlbumResponse GetAlbumsList(AlbumItem albums)
        {
            var albumArtists = albums.artists;
            return new AlbumResponse
            {
                AlbumType = albums.album_type,
                ReleaseDate = albums.release_date,
                Characteristcs = new Characteristics
                {
                    AvailableMarkets = new List<string>
                                {
                                    albums.available_markets.FirstOrDefault()
                                },
                    ExternalUrls = albums.external_urls.spotify,
                    Id = albums.id,
                    Name = albums.name,
                    Uri = albums.uri,
                    Type = albums.type
                },
                TotalAlbumTracks = albums.total_tracks,
                Images = new List<ImageResponse>
                {
                    new ImageResponse
                    {
                        Url = albums.images.FirstOrDefault().url,
                    }
                },
                Artists = new List<ArtistResponse>()
                {
                    new ArtistResponse()
                    {
                        Followers = albumArtists.FirstOrDefault().followers.total,
                        Genres = new List<string> { albumArtists.FirstOrDefault().genres.FirstOrDefault() },
                        Images = new List<ImageResponse>
                        {
                            new ImageResponse
                            {
                                Url = albumArtists.FirstOrDefault().images.FirstOrDefault().url,
                            }
                        },
                        Characteristcs = new Characteristics
                        {
                            ExternalUrls = albumArtists.FirstOrDefault().external_urls.spotify,
                            Id = albumArtists.FirstOrDefault().id,
                            Name = albumArtists.FirstOrDefault().name,
                            Uri = albumArtists.FirstOrDefault().uri,
                            Type = albumArtists.FirstOrDefault().type
                        },
                    }
                }
            };
        }

        /// <summary>Transforms to service request.</summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public SearchDataRequest TransformRequest(SearchQuery request)
        {
            var dataRequest = new SearchDataRequest
            {
                AccessToken = request.AccessToken,
                Limit = request.Limit,
                Offset = 0,
                QueryString = request.QueryString,
                Type = request.Type,
            };
            return dataRequest;
        }
    }
}
