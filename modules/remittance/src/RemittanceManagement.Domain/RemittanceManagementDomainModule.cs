using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace RemittanceManagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(RemittanceManagementDomainSharedModule)
    )]
public class RemittanceManagementDomainModule : AbpModule
{

}
