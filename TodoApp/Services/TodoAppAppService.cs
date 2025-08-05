using Volo.Abp.Application.Services;
using TodoApp.Localization;

namespace TodoApp.Services;

/* Inherit your application services from this class. */
public abstract class TodoAppAppService : ApplicationService
{
    protected TodoAppAppService()
    {
        LocalizationResource = typeof(TodoAppResource);
    }
}