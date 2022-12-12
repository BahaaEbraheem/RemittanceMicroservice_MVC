using CurrencyManagment.Localization;
using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace CurrencyManagment.Web.Menus;

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
        var l = context.GetLocalizer<CurrencyManagmentResource>();

        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(CurrencyManagmentMenus.Prefix, displayName: l["Menu:CurrencyManagment"], "~/CurrencyManagment", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
