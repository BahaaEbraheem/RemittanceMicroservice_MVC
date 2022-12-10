using CurrencyManagment.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CurrencyManagment;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(CurrencyManagmentEntityFrameworkCoreTestModule)
    )]
public class CurrencyManagmentDomainTestModule : AbpModule
{

}
