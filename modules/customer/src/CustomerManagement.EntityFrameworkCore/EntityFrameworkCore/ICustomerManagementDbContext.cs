using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace CustomerManagement.EntityFrameworkCore;

[ConnectionStringName(CustomerManagementDbProperties.ConnectionStringName)]
public interface ICustomerManagementDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
