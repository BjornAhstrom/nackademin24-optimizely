using nackademin24_optimizely.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace nackademin24_optimizely.Models.Blocks;

[ContentType(
    GUID = "0931CBA7-EE89-45D1-8CCC-A0747D5167F0",
    DisplayName = "Carousel"

)]
public class CarouselBlock : BlockData
{
    [Display(
        GroupName = SystemTabNames.Content,
        Order = 10
    )]
    [AllowedTypes(typeof(CarouselPage))]
    public virtual ContentArea Carousel { get; set; } = null!;
}
