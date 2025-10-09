using Microsoft.AspNetCore.Mvc;
using nackademin24_optimizely.Models.Pages;
using nackademin24_optimizely.Models.ViewModels;

namespace nackademin24_optimizely.Controllers;

public class ErrorPageController : PageControllerBase<ErrorPage>
{
    public IActionResult Index(ErrorPage currentPage)
    {
        var model = new ErrorPageViewModel(currentPage);

        return View(model); 
    }
}
