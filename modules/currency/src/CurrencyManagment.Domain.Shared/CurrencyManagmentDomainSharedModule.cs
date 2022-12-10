using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using CurrencyManagment.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace CurrencyManagment;

[DependsOn(
    typeof(AbpValidationModule)
)]
public class CurrencyManagmentDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CurrencyManagmentDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<CurrencyManagmentResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/CurrencyManagment");
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("CurrencyManagment", typeof(CurrencyManagmentResource));
        });
    }
}
