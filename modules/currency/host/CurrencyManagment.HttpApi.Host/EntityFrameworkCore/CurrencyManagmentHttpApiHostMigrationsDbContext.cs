using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace CurrencyManagment.EntityFrameworkCore;

public class CurrencyManagmentHttpApiHostMigrationsDbContext : AbpDbContext<CurrencyManagmentHttpApiHostMigrationsDbContext>
{
    public CurrencyManagmentHttpApiHostMigrationsDbContext(DbContextOptions<CurrencyManagmentHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureCurrencyManagment();
    }
}
