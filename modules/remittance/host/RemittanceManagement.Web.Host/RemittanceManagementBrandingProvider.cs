using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace RemittanceManagement;

[Dependency(ReplaceServices = true)]
public class RemittanceManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "RemittanceManagement";
}
