namespace nackademin24_optimizely.Business.Services.Intefaces;

public interface IDescendantService
{
    IEnumerable<T> GetDescendantOfType<T>(PageData pageData) where T : class;
}
