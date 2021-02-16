using System.Net;

namespace MangaDexApi.Serialization
{
    public interface IResponse
    {
        public HttpStatusCode Code { get; set; }

        public string Status { get; set; }

        public string? Comment { get; set; }
    }
}