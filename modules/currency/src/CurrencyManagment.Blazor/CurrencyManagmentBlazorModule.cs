using Microsoft.Extensions.DependencyInjection;
using CurrencyManagment.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace CurrencyManagment.Blazor;

[DependsOn(
    typeof(CurrencyManagmentApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class CurrencyManagmentBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<CurrencyManagmentBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<CurrencyManagmentBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new CurrencyManagmentMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(CurrencyManagmentBlazorModule).Assembly);
        });
    }
}
