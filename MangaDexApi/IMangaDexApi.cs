using System.Collections.Generic;
using System.Threading.Tasks;
using MangaDexApi.Manga.Chapters;
using MangaDexApi.Serialization;
using Refit;

namespace MangaDexApi
{
    public interface IMangaDexApi
    {
        [Get("/manga/{id}")]
        Task<Response<Manga.Manga>> GetTitle(int id);

        [Get("/manga/{id}/chapters")]
        Task<Response<List<Chapter>>> GetChapters(int id);

        [Get("/chapter/{id}")]
        Task<Response<Chapter>> GetChapter(int id);
    }
}