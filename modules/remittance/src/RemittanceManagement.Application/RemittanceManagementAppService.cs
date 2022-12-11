using RemittanceManagement.Localization;
using Volo.Abp.Application.Services;

namespace RemittanceManagement;

public abstract class RemittanceManagementAppService : ApplicationService
{
    protected RemittanceManagementAppService()
    {
        LocalizationResource = typeof(RemittanceManagementResource);
        ObjectMapperContext = typeof(RemittanceManagementApplicationModule);
    }
}
