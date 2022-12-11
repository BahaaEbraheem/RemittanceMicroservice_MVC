using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace RemittanceManagement.EntityFrameworkCore;

public class RemittanceManagementHttpApiHostMigrationsDbContext : AbpDbContext<RemittanceManagementHttpApiHostMigrationsDbContext>
{
    public RemittanceManagementHttpApiHostMigrationsDbContext(DbContextOptions<RemittanceManagementHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureRemittanceManagement();
    }
}
