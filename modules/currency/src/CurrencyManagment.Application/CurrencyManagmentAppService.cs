using CurrencyManagment.Localization;
using Volo.Abp.Application.Services;

namespace CurrencyManagment;

public abstract class CurrencyManagmentAppService : ApplicationService
{
    protected CurrencyManagmentAppService()
    {
        LocalizationResource = typeof(CurrencyManagmentResource);
        ObjectMapperContext = typeof(CurrencyManagmentApplicationModule);
    }
}
