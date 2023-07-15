using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SurezeApp.Data;
using Volo.Abp.DependencyInjection;

namespace SurezeApp.EntityFrameworkCore;

public class EntityFrameworkCoreSurezeAppDbSchemaMigrator
    : ISurezeAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSurezeAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SurezeAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SurezeAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
