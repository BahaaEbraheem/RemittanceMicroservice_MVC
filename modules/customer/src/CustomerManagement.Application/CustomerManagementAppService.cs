using CustomerManagement.Localization;
using Volo.Abp.Application.Services;

namespace CustomerManagement;

public abstract class CustomerManagementAppService : ApplicationService
{
    protected CustomerManagementAppService()
    {
        LocalizationResource = typeof(CustomerManagementResource);
        ObjectMapperContext = typeof(CustomerManagementApplicationModule);
    }
}
