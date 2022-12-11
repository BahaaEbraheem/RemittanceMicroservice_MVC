using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace RemittanceManagement;

[DependsOn(
    typeof(RemittanceManagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class RemittanceManagementApplicationContractsModule : AbpModule
{

}
