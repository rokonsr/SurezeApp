using SurezeApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace SurezeApp.Blazor;

public abstract class SurezeAppComponentBase : AbpComponentBase
{
    protected SurezeAppComponentBase()
    {
        LocalizationResource = typeof(SurezeAppResource);
    }
}
