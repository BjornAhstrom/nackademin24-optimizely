using Microsoft.AspNetCore.Mvc;
using nackademin24_optimizely.Business.Services.Intefaces;
using nackademin24_optimizely.Models.Pages;
using nackademin24_optimizely.Models.ViewModels;

namespace nackademin24_optimizely.Controllers;

public class XmlSitemapController(IXmlSitemapService sitemapService) : PageControllerBase<XmlSitemap>
{
    private readonly IXmlSitemapService _sitemapService = sitemapService;

    public IActionResult Index(XmlSitemap currentPage)
    {
        var model = new XmlSitemapViewModel(currentPage)
        {
            Pages = _sitemapService.GetPages(currentPage)
        };

        return View(model);
    }
}
