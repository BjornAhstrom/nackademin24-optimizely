using nackademin24_optimizely.Business.Interfaces;
using nackademin24_optimizely.Models.Pages;

namespace nackademin24_optimizely.Business.Services;

public class XmlSitemapService(IContentLoader contentLoader) : IXmlSitemapService
{
    private readonly IContentLoader _contentLoader = contentLoader;

    public IEnumerable<SitePageData> GetPages(XmlSiteMap currentPage)
    {
        var startPage = _contentLoader.GetAncestors(currentPage.ContentLink).FirstOrDefault(x => x is StartPage) as PageData;
        var descendants = Enumerable.Empty<SitePageData>();

        if (startPage != null)
        {
            foreach (var page in _contentLoader.GetDescendentsAndSelf(startPage.ContentLink))
            {
                yield return page;
            }
        }
    }
}
