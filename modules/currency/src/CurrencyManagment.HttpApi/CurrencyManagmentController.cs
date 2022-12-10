using CurrencyManagment.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CurrencyManagment;

public abstract class CurrencyManagmentController : AbpControllerBase
{
    protected CurrencyManagmentController()
    {
        LocalizationResource = typeof(CurrencyManagmentResource);
    }
}
