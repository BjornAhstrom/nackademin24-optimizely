using Microsoft.AspNetCore.Mvc;
using nackademin24_optimizely.Business.Services.Intefaces;
using nackademin24_optimizely.Models.Pages;
using nackademin24_optimizely.Models.ViewModels;

namespace nackademin24_optimizely.Controllers;

public class FindPageController : PageControllerBase<FindPage>
{
    private readonly IFindService _findService;
    public FindPageController(IFindService findService)
    {
        _findService = findService;
    }
    public IActionResult Index(FindPage currentPage)
    {
        var model = new FindPageViewModel(currentPage);

        return View(model); 
    }

    [HttpPost]
    public IActionResult FindContent(FindPage currentPage, string query)
    {
        var cultureInfo = currentPage.Language;

        var model = new FindPageViewModel(currentPage)
        {
            Query = query,
            Result = _findService.FindAsync(query, cultureInfo)
        };

        return View("~/Views/FindPage/Index.cshtml", model);
    }
}
