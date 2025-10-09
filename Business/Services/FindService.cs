using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Find.UnifiedSearch;
using nackademin24_optimizely.Business.Services.Intefaces;
using System.Globalization;

namespace nackademin24_optimizely.Business.Services;

public class FindService : IFindService
{
    public async Task<UnifiedSearchResults> FindAsync(string query, CultureInfo cultureInfo)
    {
        var searchClient = SearchClient.Instance;
        var language = new Language(cultureInfo.Name, "default", cultureInfo.TwoLetterISOLanguageName, "porter", null, null, null);
        var result = await searchClient.UnifiedSearchFor(query, language).GetResultAsync();

        return result;
    }
}
