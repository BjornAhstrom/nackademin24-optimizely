using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using nackademin24_optimizely.Models.Blocks;
using nackademin24_optimizely.Models.Pages;
using nackademin24_optimizely.Models.ViewModels;

namespace nackademin24_optimizely.Blocks.Carousel;


public class CarouselBlockComponent : AsyncBlockComponent<CarouselBlock>
{
    protected override async Task<IViewComponentResult> InvokeComponentAsync(CarouselBlock currentContent)
    {
        var model = new CarouselViewModel();

        if (currentContent != null)
        {
            foreach (var item in currentContent.Carousel.FilteredItems.Select(x => x.LoadContent()))
            {
                if (item is CarouselPage page)
                {
                    model.Pages.Add(page);
                }
            }
        }

        return await Task.FromResult(View("~/views/shared/carousel.cshtml", model));
    }
}
