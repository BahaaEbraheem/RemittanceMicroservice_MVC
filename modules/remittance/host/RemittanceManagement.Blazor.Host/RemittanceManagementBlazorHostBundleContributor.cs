using Volo.Abp.Bundling;

namespace RemittanceManagement.Blazor.Host;

public class RemittanceManagementBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
