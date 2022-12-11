using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace RemittanceManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(RemittanceManagementBlazorModule),
    typeof(RemittanceManagementHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class RemittanceManagementBlazorWebAssemblyModule : AbpModule
{

}
