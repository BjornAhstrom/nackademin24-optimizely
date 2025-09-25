using Microsoft.AspNetCore.Mvc;
using nackademin24_optimizely.Business.Interfaces;
using nackademin24_optimizely.Models.Pages;
using nackademin24_optimizely.Models.ViewModels;

namespace nackademin24_optimizely.Controllers;

public class XmlSitemapController(IXmlSitemapService xmlSitemapService) : PageControllerBase<XmlSiteMap>
{
    private readonly IXmlSitemapService _xmlSitemapService = xmlSitemapService;

    public IActionResult Index(XmlSiteMap currentPage)
    {
        var model = new XmlSitemapViewmodel(currentPage)
        {
            Pages = _xmlSitemapService.GetPages(currentPage),
        };

        return View(model);
    }
}
