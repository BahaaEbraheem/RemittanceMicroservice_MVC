using Localization.Resources.AbpUi;
using CurrencyManagment.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace CurrencyManagment;

[DependsOn(
    typeof(CurrencyManagmentApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class CurrencyManagmentHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(CurrencyManagmentHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<CurrencyManagmentResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
