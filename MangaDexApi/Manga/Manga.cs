using System;
using System.Collections.Generic;
using MangaDexApi.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MangaDexApi.Manga
{
    public class Manga
    {
        public ulong Id { get; set; }

        public string Title { get; set; }

        public string[] AltTitles { get; set; }

        public string Description { get; set; }

        public string[] Artist { get; set; }

        public string[] Author { get; set; }

        public Publication Publication { get; set; }

        public IEnumerable<Genre> Tags { get; set; }

        public uint LastChapter { get; set; }

        public uint LastVolume { get; set; }

        public bool IsHentai { get; set; }

        public object[] Relations { get; set; }

        public Rating Rating { get; set; }

        public ulong Views { get; set; }

        public ulong Follows { get; set; }

        public ulong Comments { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime LastUploaded { get; set; }

        public Uri MainCover { get; set; }

        [JsonConverter(typeof(SourceConverter))]
        public IEnumerable<Source> Links { get; set; }
    }
}