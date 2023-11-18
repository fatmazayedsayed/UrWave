using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;

namespace UrWave.SiteHelper
{
    public class SiteService : ISiteService
    {
        private readonly IUmbracoContextAccessor _umbracoContextAccessor;
        private readonly IUmbracoContextFactory _umbracoContextFactory;

        public SiteService(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoContextFactory umbracoContextFactory)
        {
            _umbracoContextAccessor = umbracoContextAccessor;
            _umbracoContextFactory = umbracoContextFactory;
            bool hasUmbracoContext = _umbracoContextAccessor.TryGetUmbracoContext(out _);
        }
        //public IPublishedContent GetLookUpSectionRoot(string ModelTypeAlias)
        //{
        //    using var umbracoContextReference = _umbracoContextFactory.EnsureUmbracoContext();
        //    var contentQuery = umbracoContextReference.UmbracoContext.Content;

        //    var adminRootAdmin = contentQuery?.GetAtRoot().FirstOrDefault().Children().Where(r => r.ContentType.Alias == ContentFolder.ModelTypeAlias).FirstOrDefault();
        //    return (adminRootAdmin?.FirstChild(f => f.ContentType.Alias == ModelTypeAlias) ?? null);
        //}

        public IPublishedContent GetSiteSectionRoot(string ModelTypeAlias)
        {
            using var umbracoContextReference = _umbracoContextFactory.EnsureUmbracoContext();
            var contentQuery = umbracoContextReference.UmbracoContext.Content;

            var adminRootAdmin = contentQuery?.GetAtRoot()?.FirstOrDefault()?.Children();
            return adminRootAdmin?.Where(r => r.ContentType.Alias == ModelTypeAlias)?.FirstOrDefault();
        }

        public Guid GetAdminSectionRootGUID(string ModelTypeAlias)
        {

            using var umbracoContextReference = _umbracoContextFactory.EnsureUmbracoContext();
            var contentQuery = umbracoContextReference.UmbracoContext.Content;

            var adminRootAdmin = contentQuery?.GetAtRoot()?.FirstOrDefault()?.Children();
            var data = adminRootAdmin?.Where(r => r.ContentType.Alias == ModelTypeAlias)?.FirstOrDefault();
            return data.Key;

        }
    }
}
