using RemittanceManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RemittanceManagement;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(RemittanceManagementEntityFrameworkCoreTestModule)
    )]
public class RemittanceManagementDomainTestModule : AbpModule
{

}
