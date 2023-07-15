using System.Threading.Tasks;

namespace SurezeApp.Data;

public interface ISurezeAppDbSchemaMigrator
{
    Task MigrateAsync();
}
