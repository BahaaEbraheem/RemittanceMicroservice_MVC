using CustomerManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CustomerManagement.Permissions;

public class CustomerManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CustomerManagementPermissions.GroupName, L("Permission:CustomerManagement"));

        var customersPermission = myGroup.AddPermission(CustomerManagementPermissions.Customers.Default, L("Permission:Customers"));
        customersPermission.AddChild(CustomerManagementPermissions.Customers.Create, L("Permission:Customers.Create"));
        customersPermission.AddChild(CustomerManagementPermissions.Customers.Edit, L("Permission:Customers.Edit"));
        customersPermission.AddChild(CustomerManagementPermissions.Customers.Delete, L("Permission:Customers.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CustomerManagementResource>(name);
    }
}
