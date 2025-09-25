using nackademin24_optimizely.Models.Pages;

namespace nackademin24_optimizely.Business.Services.Intefaces;

public interface IXmlSitemapService
{
    IEnumerable<SitePageData> GetPages(XmlSitemap currentPage);
}
