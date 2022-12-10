using CustomerManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CustomerManagement.Pages;

public abstract class CustomerManagementPageModel : AbpPageModel
{
    protected CustomerManagementPageModel()
    {
        LocalizationResourceType = typeof(CustomerManagementResource);
    }
}
