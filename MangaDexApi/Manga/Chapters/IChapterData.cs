using System.Collections.Generic;

namespace MangaDexApi.Manga.Chapters
{
    public interface IChapterData
    {
        public List<Chapter> Chapters { get; set; }

        public List<Group> Groups { get; set; }
    }
}