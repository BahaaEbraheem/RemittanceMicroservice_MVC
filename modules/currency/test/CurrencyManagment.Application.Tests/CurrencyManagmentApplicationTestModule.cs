using Volo.Abp.Modularity;

namespace CurrencyManagment;

[DependsOn(
    typeof(CurrencyManagmentApplicationModule),
    typeof(CurrencyManagmentDomainTestModule)
    )]
public class CurrencyManagmentApplicationTestModule : AbpModule
{

}
