using RemittanceManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace RemittanceManagement.Pages;

public abstract class RemittanceManagementPageModel : AbpPageModel
{
    protected RemittanceManagementPageModel()
    {
        LocalizationResourceType = typeof(RemittanceManagementResource);
    }
}
