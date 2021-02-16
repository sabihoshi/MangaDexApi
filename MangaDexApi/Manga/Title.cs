using System.Collections.Generic;

namespace MangaDexApi.Manga
{
    public class Title
    {
        public Manga Data { get; set; }

        public Dictionary<string, TitleChapter> Chapter { get; set; }

        public Dictionary<string, Group> Group { get; set; }

        public string Status { get; set; }
    }
}