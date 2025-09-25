using nackademin24_optimizely.Models.Pages;

namespace nackademin24_optimizely.Models.ViewModels;

public class XmlSitemapViewModel : PageViewModel<XmlSitemap>
{
    public IEnumerable<SitePageData> Pages { get; set; } = [];

    public XmlSitemapViewModel(XmlSitemap currentPage) : base(currentPage)
    {
    }

}
