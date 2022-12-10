using CurrencyManagment.Localization;
using Volo.Abp.AspNetCore.Components;

namespace CurrencyManagment.Blazor.Server.Host;

public abstract class CurrencyManagmentComponentBase : AbpComponentBase
{
    protected CurrencyManagmentComponentBase()
    {
        LocalizationResource = typeof(CurrencyManagmentResource);
    }
}
