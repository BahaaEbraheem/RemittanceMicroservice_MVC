using CurrencyManagment.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CurrencyManagment.Pages;

public abstract class CurrencyManagmentPageModel : AbpPageModel
{
    protected CurrencyManagmentPageModel()
    {
        LocalizationResourceType = typeof(CurrencyManagmentResource);
    }
}
