using Microsoft.EntityFrameworkCore;
using UrWave.Dtos;

namespace UrWave.Repository.News_Repository
{
    public class NewsRepository : INewsRepository
    {
        private readonly ILogger<NewsRepository> logger;
        public NewsRepository(ILogger<NewsRepository> logger)
        {

            this.logger = logger;

        }
        public async Task<IEnumerable<NewsDto>?> GetAll()
        {
            logger.LogInformation("Getting all News in the DB");
            var NewssEntities = await _dbContext.Newss
                .Include(a => a.NewsHorse)
                .ThenInclude(x => x.Horse)
                .AsNoTracking()
                .Where(x => !x.IsDeleted).ToListAsync();
            return NewssEntities?.Select(x => x.ToNews(null)).ToList();
        }
    }
}
