using nackademin24_optimizely.Models.Pages;

namespace nackademin24_optimizely.Models.ViewModels;

public class XmlSitemapViewmodel : PageViewModel<XmlSiteMap>
{
    public IEnumerable<SitePageData> Pages { get; set; } = [];

    public XmlSitemapViewmodel(XmlSiteMap currentPage) : base(currentPage)
    {
    }

}
