using nackademin24_optimizely.Business;
using System.ComponentModel.DataAnnotations;

namespace nackademin24_optimizely.Models.Pages;

[ContentType(
    GUID = "B1D6E2AB-6094-4CC2-AA58-B1E7A6B7278A",
    DisplayName = "Error page",
    GroupName = Globals.GroupNames.Spezialized
)]
public class ErrorPage : SitePageData
{
    [Display(
        GroupName = SystemTabNames.Content,
        Order = 10
    )]
    [CultureSpecific]
    public virtual string Heading { get; set; } = string.Empty;
}
