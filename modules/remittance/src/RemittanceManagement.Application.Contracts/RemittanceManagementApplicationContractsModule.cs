using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using CurrencyManagment;
using CustomerManagement;

namespace RemittanceManagement;

[DependsOn(
    typeof(RemittanceManagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule),
    typeof(CurrencyManagmentApplicationContractsModule),
    typeof(CustomerManagementApplicationContractsModule)
    )]
public class RemittanceManagementApplicationContractsModule : AbpModule
{

}
