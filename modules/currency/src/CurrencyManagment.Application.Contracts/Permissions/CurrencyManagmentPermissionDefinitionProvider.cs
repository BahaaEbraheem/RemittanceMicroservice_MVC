using CurrencyManagment.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CurrencyManagment.Permissions;

public class CurrencyManagmentPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CurrencyManagmentPermissions.GroupName, L("Permission:CurrencyManagment"));


        var currenciesPermission = myGroup.AddPermission(CurrencyManagmentPermissions.Currencies.Default, L("Permission:Currencies"));
        currenciesPermission.AddChild(CurrencyManagmentPermissions.Currencies.Create, L("Permission:Currencies.Create"));
        currenciesPermission.AddChild(CurrencyManagmentPermissions.Currencies.Edit, L("Permission:Currencies.Edit"));
        currenciesPermission.AddChild(CurrencyManagmentPermissions.Currencies.Delete, L("Permission:Currencies.Delete"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CurrencyManagmentResource>(name);
    }
}
