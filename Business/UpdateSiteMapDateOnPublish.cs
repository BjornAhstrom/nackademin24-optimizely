using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using nackademin24_optimizely.Models.Pages;

namespace nackademin24_optimizely.Business;

[InitializableModule]
[ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
public class UpdateSiteMapDateOnPublish : IInitializableModule
{
    public void Initialize(InitializationEngine context)
    {
        var events = ServiceLocator.Current.GetInstance<IContentEvents>();
        events.PublishedContent += OnPublishingContent;
    }

    private void OnPublishingContent(object? sender, ContentEventArgs e)
    {
        if (e.Content is SitePageData page)
        {
            page.XmlSitemapDate = DateTime.Now;
        }
    }

    public void Uninitialize(InitializationEngine context)
    {
        throw new NotImplementedException();
    }
}
