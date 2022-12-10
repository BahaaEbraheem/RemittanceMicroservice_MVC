using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace CurrencyManagment.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(CurrencyManagmentBlazorModule)
    )]
public class CurrencyManagmentBlazorServerModule : AbpModule
{

}
