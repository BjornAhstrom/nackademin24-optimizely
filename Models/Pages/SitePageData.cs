using Microsoft.CodeAnalysis.CSharp.Syntax;
using nackademin24_optimizely.Business;
using System.ComponentModel.DataAnnotations;

namespace nackademin24_optimizely.Models.Pages;

public class SitePageData : PageData
{
    [Display(
        GroupName = Globals.GroupNames.MetaData,
        Order = 100
    )]
    [CultureSpecific]
    public virtual string MetaDescription
    {
        get
        {
            var metaDescription = this.GetPropertyValue(p => p.MetaDescription);

            return !string.IsNullOrWhiteSpace(metaDescription) ? metaDescription : Name;
        }
        set => this.SetPropertyValue(p => p.MetaDescription, value);
    }
}
