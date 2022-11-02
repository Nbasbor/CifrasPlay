namespace CifrasPlay.Services.Search.Entities
{

    public class SearchDataArtist : Followers
    {
        public Artists artists { get; set; }
    }

    public class Artists
    {
        public string href { get; set; }
        public Artist[] items { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total { get; set; }
    }

}
