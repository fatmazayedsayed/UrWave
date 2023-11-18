using Microsoft.EntityFrameworkCore;
using Umbraco.Cms.Web.Common.PublishedModels;
using UrWave.Dtos;
using UrWave.Dtos.Mappers;
using UrWave.Model.Dtos;
using UrWave.SiteHelper;

namespace UrWave.Repository.News_Repository
{
    public class NewsRepository : INewsRepository
    {
        private readonly ILogger<NewsRepository> logger;
        private readonly ISiteService siteService;
        public NewsRepository(ILogger<NewsRepository> logger, ISiteService siteService)
        {
            this.siteService = siteService;
            this.logger = logger;

        }
        public async Task<IEnumerable<NewsDto>?> GetAll()
        {
            logger.LogInformation("Getting all News in the DB");

            var data = siteService.GetSiteSectionRoot(NewsList.ModelTypeAlias)
              .SafeCast<NewsList>()?.Children().OfType<NewsItem>().ToList();

            return data?.Select(x => x.ToNews()).ToList();
        }
    }
}
