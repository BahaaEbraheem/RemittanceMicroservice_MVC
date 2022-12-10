using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CurrencyManagment.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class CurrencyManagmentBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CurrencyManagment";
}
