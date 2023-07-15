using SurezeApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SurezeApp.Permissions;

public class SurezeAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SurezeAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SurezeAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SurezeAppResource>(name);
    }
}
