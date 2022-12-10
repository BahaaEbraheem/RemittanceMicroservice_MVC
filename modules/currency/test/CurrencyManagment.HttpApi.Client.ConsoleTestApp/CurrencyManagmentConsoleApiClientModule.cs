using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace CurrencyManagment;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CurrencyManagmentHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class CurrencyManagmentConsoleApiClientModule : AbpModule
{

}
