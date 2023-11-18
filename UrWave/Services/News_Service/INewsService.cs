using UrWave.Dtos;

namespace UrWave.Services.News_Service
{
    public interface INewsService
    {
        Task<BaseApiResponse<IEnumerable<NewsDto>>?> GetAll();

    }
}
