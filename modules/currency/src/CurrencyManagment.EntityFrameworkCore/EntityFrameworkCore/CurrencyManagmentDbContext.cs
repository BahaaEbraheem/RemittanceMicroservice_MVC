using CurrencyManagment.Currencies;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace CurrencyManagment.EntityFrameworkCore;

[ConnectionStringName(CurrencyManagmentDbProperties.ConnectionStringName)]
public class CurrencyManagmentDbContext : AbpDbContext<CurrencyManagmentDbContext>, ICurrencyManagmentDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
    public DbSet<Currency> Currencies { get; set; }
    public CurrencyManagmentDbContext(DbContextOptions<CurrencyManagmentDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureCurrencyManagment();
    }
}
