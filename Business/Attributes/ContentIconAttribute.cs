using nackademin24_optimizely.Business.Enums;

namespace nackademin24_optimizely.Business.Attributes;

public class ContentIconAttribute : Attribute
{
    public ContentIcon Icon { get; set; }

    public ContentIconAttribute(ContentIcon icon)
    {
        Icon = icon;
    }
}
