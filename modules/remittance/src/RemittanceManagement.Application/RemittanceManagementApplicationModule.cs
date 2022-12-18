using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using CurrencyManagment;
using CustomerManagement;

namespace RemittanceManagement;

[DependsOn(
    typeof(RemittanceManagementDomainModule),
    typeof(RemittanceManagementApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule),
    typeof(CurrencyManagmentHttpApiClientModule),
    typeof(CustomerManagementHttpApiClientModule)

    )]
public class RemittanceManagementApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<RemittanceManagementApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<RemittanceManagementApplicationModule>(validate: true);
        });
    }
}
