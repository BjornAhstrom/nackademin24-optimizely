using EPiServer.Find.UnifiedSearch;
using System.Globalization;

namespace nackademin24_optimizely.Business.Services.Intefaces;

public interface IFindService
{
    Task<UnifiedSearchResults> FindAsync(string query, CultureInfo cultureInfo);
}
