using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace RemittanceManagement;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class RemittanceManagementInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<RemittanceManagementInstallerModule>();
        });
    }
}
