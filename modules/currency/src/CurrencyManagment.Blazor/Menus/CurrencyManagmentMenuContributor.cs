using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace CurrencyManagment.Blazor.Menus;

public class CurrencyManagmentMenuContributor : IMenuContributor
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
        context.Menu.AddItem(new ApplicationMenuItem(CurrencyManagmentMenus.Prefix, displayName: "CurrencyManagment", "/CurrencyManagment", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
