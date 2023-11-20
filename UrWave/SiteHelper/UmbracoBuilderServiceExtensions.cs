using UrWave.Repository.News_Repository;
using UrWave.Services.News_Service;

namespace UrWave.SiteHelper
{
    public static class UmbracoBuilderServiceExtensions
    {
        public static IUmbracoBuilder AddCustomServices(this IUmbracoBuilder builder)
        {
            builder.Services.AddSingleton<ISiteService, SiteService>();

            //builder.Services.AddScoped<INewsRepository, NewsRepository>();
            //builder.Services.AddScoped<INewsService, NewsService>();

            return builder;

        }
    }
}
