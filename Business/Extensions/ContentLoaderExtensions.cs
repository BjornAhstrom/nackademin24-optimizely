using nackademin24_optimizely.Models.Pages;

namespace nackademin24_optimizely.Business.Extensions;

public static class ContentLoaderExtensions
{
    public static IEnumerable<SitePageData> GetDescendantsAndSelf(this IContentLoader contentLoader, ContentReference contentReference)
    {
        var startPage = contentLoader.Get<SitePageData>(contentReference);
        var descendants = contentLoader.GetDescendents(contentReference)
            .Select(contentLoader.Get<IContent>)
            .Where(content => content is SitePageData and not XmlSitemap)
            .Cast<SitePageData>();

        return new[] { startPage }.Concat(descendants);
    }
}
