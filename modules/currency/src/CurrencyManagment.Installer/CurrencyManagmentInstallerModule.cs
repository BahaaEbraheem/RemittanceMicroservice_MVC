using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace CurrencyManagment;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class CurrencyManagmentInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CurrencyManagmentInstallerModule>();
        });
    }
}
