using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace CurrencyManagment;

[DependsOn(
    typeof(CurrencyManagmentApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class CurrencyManagmentHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(CurrencyManagmentApplicationContractsModule).Assembly,
            CurrencyManagmentRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CurrencyManagmentHttpApiClientModule>();
        });

    }
}
