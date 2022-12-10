using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace CustomerManagement;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CustomerManagementHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class CustomerManagementConsoleApiClientModule : AbpModule
{

}
