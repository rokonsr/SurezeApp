using SurezeApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SurezeApp;

[DependsOn(
    typeof(SurezeAppEntityFrameworkCoreTestModule)
    )]
public class SurezeAppDomainTestModule : AbpModule
{

}
