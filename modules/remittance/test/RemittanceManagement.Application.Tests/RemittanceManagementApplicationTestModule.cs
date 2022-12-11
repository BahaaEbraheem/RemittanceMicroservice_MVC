using Volo.Abp.Modularity;

namespace RemittanceManagement;

[DependsOn(
    typeof(RemittanceManagementApplicationModule),
    typeof(RemittanceManagementDomainTestModule)
    )]
public class RemittanceManagementApplicationTestModule : AbpModule
{

}
