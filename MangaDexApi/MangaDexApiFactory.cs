using Refit;

namespace MangaDexApi
{
    public static class MangaDexApiFactory
    {
        public static IMangaDexApi Create()
        {
            return RestService.For<IMangaDexApi>("https://mangadex.org/api/v2");
        }
    }
}