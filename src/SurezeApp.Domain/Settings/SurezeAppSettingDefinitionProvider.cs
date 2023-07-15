using Volo.Abp.Settings;

namespace SurezeApp.Settings;

public class SurezeAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SurezeAppSettings.MySetting1));
    }
}
