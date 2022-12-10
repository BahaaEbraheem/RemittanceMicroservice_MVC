using Volo.Abp.Bundling;

namespace CurrencyManagment.Blazor.Host;

public class CurrencyManagmentBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
