using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace CustomerManagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(CustomerManagementDomainSharedModule)
)]
public class CustomerManagementDomainModule : AbpModule
{

}
