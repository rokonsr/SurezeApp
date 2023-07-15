using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SurezeApp.Data;

/* This is used if database provider does't define
 * ISurezeAppDbSchemaMigrator implementation.
 */
public class NullSurezeAppDbSchemaMigrator : ISurezeAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
