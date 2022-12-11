using RemittanceManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace RemittanceManagement.Blazor.Server.Host;

public abstract class RemittanceManagementComponentBase : AbpComponentBase
{
    protected RemittanceManagementComponentBase()
    {
        LocalizationResource = typeof(RemittanceManagementResource);
    }
}
