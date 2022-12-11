using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace RemittanceManagement.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class RemittanceManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "RemittanceManagement";
}
