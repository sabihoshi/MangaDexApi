using System.Collections.Generic;
using MangaDexApi.Serialization;

namespace MangaDexApi.Manga
{
    public class Title : Response<Manga>
    {
        public Dictionary<string, TitleChapter> Chapter { get; set; }

        public Dictionary<string, GroupData> Group { get; set; }
    }
}