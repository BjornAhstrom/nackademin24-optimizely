using Microsoft.CodeAnalysis.CSharp.Syntax;
using nackademin24_optimizely.Business;
using System.ComponentModel.DataAnnotations;

namespace nackademin24_optimizely.Models.Pages;

[ContentType(
    GUID = "6F77D127-5FB3-46AC-A157-ACF78FA077F5",
    GroupName = Globals.GroupNames.Spezialized
)]
public class StartPage : SitePageData
{
    [Display(
        GroupName = SystemTabNames.Content,
        Order = 10
    )]

    public virtual string Heading { get; set; } = string.Empty;
}
