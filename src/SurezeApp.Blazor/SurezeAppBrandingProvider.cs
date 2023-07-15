using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SurezeApp.Blazor;

[Dependency(ReplaceServices = true)]
public class SurezeAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SurezeApp";
}
