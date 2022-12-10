using CurrencyManagment.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CurrencyManagment.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CurrencyManagmentPageModel : AbpPageModel
{
    protected CurrencyManagmentPageModel()
    {
        LocalizationResourceType = typeof(CurrencyManagmentResource);
        ObjectMapperContext = typeof(CurrencyManagmentWebModule);
    }
}
