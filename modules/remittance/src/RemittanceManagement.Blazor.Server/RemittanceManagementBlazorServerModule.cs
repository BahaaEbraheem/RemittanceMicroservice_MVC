using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace RemittanceManagement.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(RemittanceManagementBlazorModule)
    )]
public class RemittanceManagementBlazorServerModule : AbpModule
{

}
