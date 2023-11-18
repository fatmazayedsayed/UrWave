using UrWave.Dtos;
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
            var Newss = await NewsRepository.GetAll();
            return new BaseApiResponse<IEnumerable<NewsDto>>()
            {
                Result = Newss,
                PaginationInfo = new PaginationInfoDto()
                {
                    TotalCount = Newss != null ? Newss.Count() : 0
                }
            };
        }

    }
}
