using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace RemittanceManagement;

[DependsOn(
    typeof(RemittanceManagementApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class RemittanceManagementHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(RemittanceManagementApplicationContractsModule).Assembly,
            RemittanceManagementRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<RemittanceManagementHttpApiClientModule>();
        });

    }
}
