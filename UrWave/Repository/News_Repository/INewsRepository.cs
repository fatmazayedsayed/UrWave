using UrWave.Dtos;
using UrWave.Model.Dtos;

namespace UrWave.Repository.News_Repository
{
    public interface INewsRepository
    {
        Task<IEnumerable<NewsDto>?> GetAll();

    }
}
