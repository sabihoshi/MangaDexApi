using Newtonsoft.Json;

namespace MangaDexApi.Manga
{
    public class GroupData
    {
        [JsonProperty("group_name")] public string Name { get; set; }
    }

    public class Group
    {
        public uint Id { get; set; }

        public string Name { get; set; }
    }
}