namespace CifrasPlay.Services.Search.Entities
{
    public class SearchAlbumData : SearchDataArtist
    {
        public Albums albums { get; set; }
    }
    public class Albums
    {
        public string href { get; set; }
        public AlbumItem[] items { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total { get; set; }
    }

    public class AlbumItem
    {
        public string album_type { get; set; }
        public Artist[] artists { get; set; }
        public string[] available_markets { get; set; }
        public External_Urls external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public Image[] images { get; set; }
        public string name { get; set; }
        public string release_date { get; set; }
        public string release_date_precision { get; set; }
        public int total_tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }


}

