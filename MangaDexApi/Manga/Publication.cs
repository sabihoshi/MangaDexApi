namespace MangaDexApi.Manga
{
    public class Publication
    {
        public enum DemographicType
        {
            Shounen = 1,
            Shoujo = 2,
            Seinen = 3,
            Josei = 4
        }

        public enum PublicationStatus
        {
            Ongoing = 1,
            Completed = 2,
            Cancelled = 3,
            Hiatus = 4
        }

        public string Language { get; set; }

        public PublicationStatus Status { get; set; }

        public DemographicType Demographic { get; set; }
    }
}