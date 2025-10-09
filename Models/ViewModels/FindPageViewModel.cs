using EPiServer.Find.UnifiedSearch;
using nackademin24_optimizely.Models.Pages;

namespace nackademin24_optimizely.Models.ViewModels;

public class FindPageViewModel : PageViewModel<FindPage>
{

    public FindPageViewModel(FindPage currentPage) : base(currentPage)
    {
        
    }

    public string Query { get; set; }
    public Task<UnifiedSearchResults> Result { get; set; }
}
