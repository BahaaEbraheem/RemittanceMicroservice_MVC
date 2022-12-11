using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace RemittanceManagement.Blazor.Menus;

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
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(RemittanceManagementMenus.Prefix, displayName: "RemittanceManagement", "/RemittanceManagement", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
