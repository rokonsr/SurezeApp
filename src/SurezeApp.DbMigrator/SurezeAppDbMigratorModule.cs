using SurezeApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SurezeApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SurezeAppEntityFrameworkCoreModule),
    typeof(SurezeAppApplicationContractsModule)
    )]
public class SurezeAppDbMigratorModule : AbpModule
{

}
