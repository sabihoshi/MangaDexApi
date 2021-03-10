using System.Collections.Generic;
using Newtonsoft.Json;

namespace MangaDexApi.Manga.Chapters
{
    public class Chapter
    {
        public int Id { get; set; }

        public string Hash { get; set; }

        public int MangaId { get; set; }

        public string MangaTitle { get; set; }

        public string Volume { get; set; }

        [JsonProperty("chapter")] public double ChapterNo { get; set; }

        public string Title { get; set; }

        public string Language { get; set; }

        public IReadOnlyCollection<Group> Groups { get; set; }

        public int Uploader { get; set; }

        public int Timestamp { get; set; }

        public int ThreadId { get; set; }

        public int Comments { get; set; }

        public int Views { get; set; }

        public string Status { get; set; }

        public string[] Pages { get; set; }

        public string Server { get; set; }

        public string ServerFallback { get; set; }
    }
}