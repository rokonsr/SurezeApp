using System;
using System.Collections.Generic;
using System.Text;
using SurezeApp.Localization;
using Volo.Abp.Application.Services;

namespace SurezeApp;

/* Inherit your application services from this class.
 */
public abstract class SurezeAppAppService : ApplicationService
{
    protected SurezeAppAppService()
    {
        LocalizationResource = typeof(SurezeAppResource);
    }
}
