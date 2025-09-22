using EPiServer.Web;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using nackademin24_optimizely.Business;
using System.ComponentModel.DataAnnotations;

namespace nackademin24_optimizely.Models.Pages;

[ContentType(
    GUID = "6F77D127-5FB3-46AC-A157-ACF78FA077F5",
    GroupName = Globals.GroupNames.Spezialized
)]

[ImageUrl("/pages/CMS-icon-page-02.png")]
public class StartPage : SitePageData
{
    [Display(
        GroupName = SystemTabNames.Content,
        Order = 10
    )]
    [CultureSpecific]
    public virtual string Heading { get; set; } = string.Empty;

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 20
    )]
    [CultureSpecific]
    [UIHint(UIHint.Textarea)]
    public virtual string Preamble { get; set; } = string.Empty;

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 30
    )]
    [CultureSpecific]
    public virtual XhtmlString MainBody { get; set; } = null!;

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 40
    )]
    [UIHint(UIHint.Image)]
    public virtual ContentReference Image { get; set; } = null!;
}
