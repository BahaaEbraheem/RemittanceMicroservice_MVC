using RemittanceManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RemittanceManagement;

public abstract class RemittanceManagementController : AbpControllerBase
{
    protected RemittanceManagementController()
    {
        LocalizationResource = typeof(RemittanceManagementResource);
    }
}
