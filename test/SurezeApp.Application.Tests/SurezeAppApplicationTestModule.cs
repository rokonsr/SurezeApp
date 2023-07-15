using Volo.Abp.Modularity;

namespace SurezeApp;

[DependsOn(
    typeof(SurezeAppApplicationModule),
    typeof(SurezeAppDomainTestModule)
    )]
public class SurezeAppApplicationTestModule : AbpModule
{

}
