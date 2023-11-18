using Umbraco.Cms.Core.Models.PublishedContent;

namespace UrWave.SiteHelper
{
    public interface ISiteService
    {
        IPublishedContent GetSiteSectionRoot(string ModelTypeAlias);
        //IPublishedContent GetLookUpSectionRoot(string ModelTypeAlias);
         Guid GetAdminSectionRootGUID(string ModelTypeAlias);

    }
}
