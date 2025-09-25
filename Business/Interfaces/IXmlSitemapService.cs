using nackademin24_optimizely.Models.Pages;

namespace nackademin24_optimizely.Business.Interfaces;

public interface IXmlSitemapService
{
    IEnumerable<SitePageData> GetPages(XmlSiteMap currentPage);
}
