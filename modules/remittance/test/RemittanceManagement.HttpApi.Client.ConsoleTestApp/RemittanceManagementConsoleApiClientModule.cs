using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace RemittanceManagement;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(RemittanceManagementHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class RemittanceManagementConsoleApiClientModule : AbpModule
{

}
