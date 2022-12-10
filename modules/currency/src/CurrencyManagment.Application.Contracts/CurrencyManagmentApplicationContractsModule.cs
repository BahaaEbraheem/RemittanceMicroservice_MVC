using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace CurrencyManagment;

[DependsOn(
    typeof(CurrencyManagmentDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class CurrencyManagmentApplicationContractsModule : AbpModule
{

}
