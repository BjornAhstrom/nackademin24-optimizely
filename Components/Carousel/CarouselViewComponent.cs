using EPiServer.Web;
using Microsoft.AspNetCore.Mvc;
using nackademin24_optimizely.Models.Pages;
using nackademin24_optimizely.Models.ViewModels;

namespace nackademin24_optimizely.Components.Carousel;

public class CarouselViewComponent : ViewComponent
{
    private readonly IContentLoader _contentLoader;

    public CarouselViewComponent(IContentLoader contentLoader)
    {
        _contentLoader = contentLoader;
    }

    public IViewComponentResult Invoke(IContentLoader contentLoader)
    {
        var startPage = _contentLoader.Get<StartPage>(SiteDefinition.Current.StartPage);
        var viewModel = new CarouselViewModel();

        if (startPage.Carousel != null)
        {
            foreach ( var item in startPage.Carousel.FilteredItems.Select(x => x.LoadContent()))
            {
                if (item is CarouselPage page)
                {
                    viewModel.Pages.Add(page);
                }
            }
        }

        return View("~/views/shared/Carousel.cshtml", viewModel);
    }
}
