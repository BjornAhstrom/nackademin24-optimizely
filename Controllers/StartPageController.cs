using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using nackademin24_optimizely.Models.Pages;
using nackademin24_optimizely.Models.ViewModels;

namespace nackademin24_optimizely.Controllers;

public class StartPageController : PageControllerBase<StartPage>
{

    public IActionResult Index(StartPage currentPage)
    {
        var model = new StartPageViewModel(currentPage);

        return View(model); 
    }
}
