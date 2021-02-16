using Newtonsoft.Json;

namespace MangaDexApi.Manga
{
    public class Group
    {
        [JsonProperty("group_name")] public string Name { get; set; }
    }
}