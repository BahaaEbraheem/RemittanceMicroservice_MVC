using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CurrencyManagment;

[Dependency(ReplaceServices = true)]
public class CurrencyManagmentBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CurrencyManagment";
}
