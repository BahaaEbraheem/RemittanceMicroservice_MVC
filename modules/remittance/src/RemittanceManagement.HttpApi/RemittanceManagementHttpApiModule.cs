using Localization.Resources.AbpUi;
using RemittanceManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace RemittanceManagement;

[DependsOn(
    typeof(RemittanceManagementApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class RemittanceManagementHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(RemittanceManagementHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<RemittanceManagementResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
