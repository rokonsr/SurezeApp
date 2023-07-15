using System.Threading.Tasks;
using SurezeApp.Localization;
using SurezeApp.MultiTenancy;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace SurezeApp.Blazor.Menus;

public class SurezeAppMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<SurezeAppResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                SurezeAppMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        context.Menu.AddItem(
            new ApplicationMenuItem(
                "Patients",
                l["Menu:Patients"],
                icon: "fa fa-users"
            ).AddItem(
                new ApplicationMenuItem(
                    "Patients.Patients",
                    l["Menu:Patients List"],
                    url: "/Patients"
                )
            ).AddItem(
                new ApplicationMenuItem(
                    "Patients.Patients",
                    l["Menu:Register Patient"],
                    url: "/Registration"
                )
            )
        );

        return Task.CompletedTask;
    }
}
