using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace CurrencyManagment.Blazor.WebAssembly;

[DependsOn(
    typeof(CurrencyManagmentBlazorModule),
    typeof(CurrencyManagmentHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class CurrencyManagmentBlazorWebAssemblyModule : AbpModule
{

}
