using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;
using RemittanceManagement.Localization;
using Microsoft.Extensions.Localization;
using RemittanceManagement.Permissions;

namespace RemittanceManagement.Web.Menus;

public class RemittanceManagementMenuContributor : IMenuContributor
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
        var l = context.GetLocalizer<RemittanceManagementResource>();

        var RMSMenu = new ApplicationMenuItem(RemittanceManagementMenus.RemittancesStatus, l["Menu:RemittancesStatus"], url: "/remittancesstatus", icon: "fas fa-home", order: 0);



        RMSMenu.AddItem(new ApplicationMenuItem(RemittanceManagementMenus.RemittancesStatus, l["Menu:RemittancesStatus"],url: "/remittancesstatus",icon: "fas fa-home",order: 0));
        //if (context.IsGrantedAsync(RemittanceManagementPermissions.Status.Create).Result)
        //{
        RMSMenu.AddItem(new ApplicationMenuItem(RemittanceManagementMenus.Remittances,l["Menu:Remittances"],url: "~/RemittanceManagement", icon: "fas fa-home",order: 0));
        //}
        //if (context.IsGrantedAsync(RemittanceManagementPermissions.Status.Approved).Result)
        //{
        RMSMenu.AddItem(new ApplicationMenuItem(RemittanceManagementMenus.ReadyRemittances,l["Menu:ReadyRemittances"],url: "/readyremittances",icon: "fas fa-home",order: 0));
        //}
        //if (context.IsGrantedAsync(RemittanceManagementPermissions.Status.Released).Result)
        //{
        RMSMenu.AddItem(new ApplicationMenuItem(RemittanceManagementMenus.ApprovedRemittances,l["Menu:ApprovedRemittances"],url: "/approvedremittances",icon: "fas fa-home",order: 0));
        //}
        context.Menu.AddItem(RMSMenu);

        //Add main menu items.
        //context.Menu.AddItem(new ApplicationMenuItem(RemittanceManagementMenus.Prefix, displayName: "RemittanceManagement", "~/RemittanceManagement", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
