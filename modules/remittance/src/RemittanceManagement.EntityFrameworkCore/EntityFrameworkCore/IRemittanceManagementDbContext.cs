using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace RemittanceManagement.EntityFrameworkCore;

[ConnectionStringName(RemittanceManagementDbProperties.ConnectionStringName)]
public interface IRemittanceManagementDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
