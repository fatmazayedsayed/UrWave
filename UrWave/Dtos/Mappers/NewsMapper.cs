using Umbraco.Cms.Web.Common.PublishedModels;
using UrWave.Model.Dtos;

namespace UrWave.Dtos.Mappers
{
    public static class NewsMapper
    {
        public static NewsDto ToNews(this NewsItem News)
        {
            var NewsDetails = new NewsDto
            {
                Id = News.Id,
                News_Description = News.News_Description,
                News_Name = News.News_Name,
            };
            return NewsDetails;
        }

    }
}
