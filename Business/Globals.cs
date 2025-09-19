using System.ComponentModel.DataAnnotations;

namespace nackademin24_optimizely.Business
{
    public class Globals
    {
        [GroupDefinitions]
        public static class GroupNames
        {
            [Display(
                Name = "Metadata",
                Order = 40
            )]
            public const string MetaData = "Metadata";

            [Display(
                Name = "Spezialized",
                Order = 90
            )]
            public const string Spezialized = "Spezialized";
        }
    }
}
