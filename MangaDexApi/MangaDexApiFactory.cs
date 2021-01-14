using MangaDexApi.Serialization;
using Refit;

namespace MangaDexApi
{
    public static class MangaDexApiFactory
    {
        public static IMangaDexApi Create()
        {
            return RestService.For<IMangaDexApi>("https://mangadex.org/api/v1",
                new RefitSettings
                {
                    ContentSerializer = new NewtonsoftJsonContentSerializer(
                        new MangaDexSerializerSettings())
                });
        }
    }
}