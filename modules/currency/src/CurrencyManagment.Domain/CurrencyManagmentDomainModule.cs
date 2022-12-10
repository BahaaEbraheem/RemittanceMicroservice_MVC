using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace CurrencyManagment;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(CurrencyManagmentDomainSharedModule)
)]
public class CurrencyManagmentDomainModule : AbpModule
{

}
