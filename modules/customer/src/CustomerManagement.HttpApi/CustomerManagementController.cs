using CustomerManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CustomerManagement;

public abstract class CustomerManagementController : AbpControllerBase
{
    protected CustomerManagementController()
    {
        LocalizationResource = typeof(CustomerManagementResource);
    }
}
