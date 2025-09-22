using Microsoft.AspNetCore.Mvc;
using nackademin24_optimizely.Models.Pages;
using nackademin24_optimizely.Models.ViewModels;

namespace nackademin24_optimizely.Controllers;

public class ArticlePageController : PageControllerBase<ArticlePage>
{
    public IActionResult Index(ArticlePage currentPage)
    {
        var model = new ArticlePageViewModel(currentPage);

        return View(model); 
    }
}
