using CustomerManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace CustomerManagement.Blazor.Server.Host;

public abstract class CustomerManagementComponentBase : AbpComponentBase
{
    protected CustomerManagementComponentBase()
    {
        LocalizationResource = typeof(CustomerManagementResource);
    }
}
