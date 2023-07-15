using SurezeApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SurezeApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SurezeAppController : AbpControllerBase
{
    protected SurezeAppController()
    {
        LocalizationResource = typeof(SurezeAppResource);
    }
}
