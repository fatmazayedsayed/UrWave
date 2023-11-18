using UrWave.Dtos;
using UrWave.Model.Dtos;
using UrWave.Repository.News_Repository;

namespace UrWave.Services.News_Service
{
    public class NewsService:INewsService
    {
        private readonly INewsRepository NewsRepository;
        public NewsService(INewsRepository NewsRepository)
        {
            this.NewsRepository = NewsRepository;
        }
        public async Task<BaseApiResponse<IEnumerable<NewsDto>>?> GetAll()
        {
            var data = await NewsRepository.GetAll();
            return new BaseApiResponse<IEnumerable<NewsDto>>()
            {
                Result = data,
                PaginationInfo = new PaginationInfoDto()
                {
                    TotalCount = data != null ? data.Count() : 0
                }
            };
        }

    }
}
