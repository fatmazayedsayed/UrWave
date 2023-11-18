using Umbraco.Cms.Core.Models.PublishedContent;
using UrWave.SiteHelper;

namespace UrWave.UmbracoMappers
{
    public static class UmbracoModelMapper
    {
        public static IEnumerable<TChild>? GetSectionData<TChild, TRoot>(ISiteService siteService, string modelTypeAlias)
        where TChild : IPublishedContent
        where TRoot : IPublishedContent
        {
            var data = siteService.GetSiteSectionRoot(modelTypeAlias);
            var dataListed = data?.SafeCast<TRoot>()?.Children().OfType<TChild>();
            return dataListed;
        }

        //public static IEnumerable<TChild>? GetSectionLookUpData<TChild, TRoot>(ISiteService siteService, string modelTypeAlias)
        //where TChild : IPublishedContent
        //where TRoot : IPublishedContent
        //{
        //    var data = siteService.GetLookUpSectionRoot(modelTypeAlias);
        //    var dataListed = data?.SafeCast<TRoot>()?.Children().OfType<TChild>();
        //    return dataListed;
        //}
    }

}
