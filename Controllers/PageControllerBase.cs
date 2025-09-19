using EPiServer.Web.Mvc;
using nackademin24_optimizely.Models.Pages;

namespace nackademin24_optimizely.Controllers;

public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
{
}
