using nackademin24_optimizely.Business;
using nackademin24_optimizely.Business.Attributes;
using nackademin24_optimizely.Business.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace nackademin24_optimizely.Models.Pages;

[ContentType(
    GUID = "8049616C-328B-4512-A47F-FA08C9CB7F87",
    GroupName = Globals.GroupNames.Spezialized,
    DisplayName = "Carousel",
    Description = ""
)]
[ContentIcon(ContentIcon.ObjectImage)]
public class CarouselPage : SitePageData
{
    [Display(
        GroupName = SystemTabNames.Content,
        Order = 10
    )]
    public virtual ContentReference Image { get; set; } = null!;
}
