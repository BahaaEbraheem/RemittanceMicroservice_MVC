using Volo.Abp.Modularity;

namespace CustomerManagement;

[DependsOn(
    typeof(CustomerManagementApplicationModule),
    typeof(CustomerManagementDomainTestModule)
    )]
public class CustomerManagementApplicationTestModule : AbpModule
{

}
