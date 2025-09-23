using nackademin24_optimizely.Business;
using nackademin24_optimizely.Business.Attributes;
using nackademin24_optimizely.Business.Enums;
using nackademin24_optimizely.Models.Interfaces;

namespace nackademin24_optimizely.Models.Pages;

[ContentType(
    GUID = "84722F6F-0D72-49F8-9FC0-0138C647929B",
    GroupName = Globals.GroupNames.Spezialized,
    DisplayName = "Container"
)]
[AvailableContentTypes(
    Availability.Specific,
    Include = [typeof(CarouselPage)]
)]
[ContentIcon(ContentIcon.Folder)]
public class ContainerPage : PageData, IContainerPage
{
}
