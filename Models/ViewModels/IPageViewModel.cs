using nackademin24_optimizely.Models.Pages;

namespace nackademin24_optimizely.Models.ViewModels;

public interface IPageViewModel<out T> where T : SitePageData
{
    T CurrentPage { get; }

    LayoutModel Layout { get; set; }
}
