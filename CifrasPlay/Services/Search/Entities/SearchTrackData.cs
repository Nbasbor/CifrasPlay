namespace CifrasPlay.Services.Search.Entities
{

    public class SearchTrackData : SearchAlbumData
    {
        public Tracks tracks { get; set; }
    }

    public class Rootobject
    {
        public Tracks tracks { get; set; }
    }

    public class Tracks
    {
        public string href { get; set; }
        public TrackItem[] items { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total { get; set; }
    }

    public class TrackItem
    {
        public AlbumItem album { get; set; }
        public Artist[] artists { get; set; }
        public string[] available_markets { get; set; }
        public int disc_number { get; set; }
        public int duration_ms { get; set; }
        public bool _explicit { get; set; }
        public External_Ids external_ids { get; set; }
        public External_Urls2 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public bool is_local { get; set; }
        public string name { get; set; }
        public int popularity { get; set; }
        public string preview_url { get; set; }
        public int track_number { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class External_Ids
    {
        public string isrc { get; set; }
    }

    public class External_Urls2
    {
        public string spotify { get; set; }
    }
}
