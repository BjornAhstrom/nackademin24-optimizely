using EPiServer.PlugIn;
using EPiServer.Scheduler;
using EPiServer.Web;
using nackademin24_optimizely.Business.Services.Intefaces;
using nackademin24_optimizely.Models.Pages;

namespace nackademin24_optimizely.Business.ScheduledJobs;

[ScheduledPlugIn(
    GUID = "57B4C584-F149-4398-BC3F-7677DB733CCA",
    DisplayName = "Delete unpublished carousel pages"
)]
public class DeleteUnpublishedCarouselPages : ScheduledJobBase
{
    private readonly IContentLoader _contentLoader;
    private readonly ISiteDefinitionRepository _siteDefinitionRepository;
    private readonly IContentRepository _contentRepository;
    private readonly IDescendantService _descendantService;
    private bool _stopSignal;

    public DeleteUnpublishedCarouselPages(IContentLoader contentLoader, ISiteDefinitionRepository siteDefinitionRepository, IContentRepository contentRepository, IDescendantService descendantService)
    {
        _contentLoader = contentLoader;
        _siteDefinitionRepository = siteDefinitionRepository;
        _contentRepository = contentRepository;
        _descendantService = descendantService;
        IsStoppable = true;
    }

    public override void Stop()
    {
        _stopSignal = true;
    }

    public override string Execute()
    {
        var carouselPages = GetCarouselPages();
        var status = 0;

        foreach (var item in carouselPages)
        {
            if (item.StopPublish != null)
            {
                _contentRepository.Delete(item.ContentLink, true, EPiServer.Security.AccessLevel.NoAccess);

                status++;
            }
        }

        if (_stopSignal){
            return $"The job has been deleted";
        }

        return $"Unpublished carousel pages deleted: {status}";
    }

    private IEnumerable<CarouselPage> GetCarouselPages()
    {
        var contentReference = _siteDefinitionRepository.List().FirstOrDefault()!.StartPage;
        var startPage = _contentLoader.Get<StartPage>(contentReference);
        var carouselPages = _descendantService.GetDescendantOfType<CarouselPage>(startPage).ToList();

        return carouselPages;
    }
}
