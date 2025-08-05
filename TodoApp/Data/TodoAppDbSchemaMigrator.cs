using Volo.Abp.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace TodoApp.Data;

public class TodoAppDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public TodoAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        
        /* We intentionally resolving the TodoAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TodoAppDbContext>()
            .Database
            .MigrateAsync();

    }
}
