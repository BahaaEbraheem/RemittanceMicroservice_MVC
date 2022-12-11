using RemittanceManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RemittanceManagement.Permissions;

public class RemittanceManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(RemittanceManagementPermissions.GroupName, L("Permission:RemittanceManagement"));



        var remittancesPermission = myGroup.AddPermission(RemittanceManagementPermissions.Remittances.Default, L("Permission:Remittances"));
        remittancesPermission.AddChild(RemittanceManagementPermissions.Remittances.Create, L("Permission:Remittances.Create"));
        remittancesPermission.AddChild(RemittanceManagementPermissions.Remittances.Edit, L("Permission:Remittances.Edit"));
        remittancesPermission.AddChild(RemittanceManagementPermissions.Remittances.Delete, L("Permission:Remittances.Delete"));

        var StatusPermission = myGroup.AddPermission(RemittanceManagementPermissions.Status.Default, L("Permission:Status"));
        StatusPermission.AddChild(RemittanceManagementPermissions.Status.Create, L("Permission:Status.Create"));
        StatusPermission.AddChild(RemittanceManagementPermissions.Status.Approved, L("Permission:Status.Approved"));
        StatusPermission.AddChild(RemittanceManagementPermissions.Status.Ready, L("Permission:Status.Ready"));
        StatusPermission.AddChild(RemittanceManagementPermissions.Status.Released, L("Permission:Status.Released"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<RemittanceManagementResource>(name);
    }
}
