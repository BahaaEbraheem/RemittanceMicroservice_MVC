using RemittanceManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace RemittanceManagement.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class RemittanceManagementPageModel : AbpPageModel
{
    protected RemittanceManagementPageModel()
    {
        LocalizationResourceType = typeof(RemittanceManagementResource);
        ObjectMapperContext = typeof(RemittanceManagementWebModule);
    }
}
