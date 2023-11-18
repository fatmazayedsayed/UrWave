using UrWave.Dtos;
using UrWave.Model.Dtos;

namespace UrWave.Services.News_Service
{
    public interface INewsService
    {
        Task<BaseApiResponse<IEnumerable<NewsDto>>?> GetAll();

    }
}
