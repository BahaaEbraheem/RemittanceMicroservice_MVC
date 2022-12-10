using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CustomerManagement;

[Dependency(ReplaceServices = true)]
public class CustomerManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CustomerManagement";
}
