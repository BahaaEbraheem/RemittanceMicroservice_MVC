using Microsoft.EntityFrameworkCore;
using RemittanceManagement.Remittances;
using RemittanceManagement.Status;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace RemittanceManagement.EntityFrameworkCore;

[ConnectionStringName(RemittanceManagementDbProperties.ConnectionStringName)]
public class RemittanceManagementDbContext : AbpDbContext<RemittanceManagementDbContext>, IRemittanceManagementDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
      public DbSet<Remittance> Remittances { get; set; }
        public DbSet<RemittanceStatus> RemittanceStatus { get; set; }
    public RemittanceManagementDbContext(DbContextOptions<RemittanceManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureRemittanceManagement();
    }
}
