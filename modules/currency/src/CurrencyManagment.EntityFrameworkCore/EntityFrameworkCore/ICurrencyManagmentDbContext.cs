using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace CurrencyManagment.EntityFrameworkCore;

[ConnectionStringName(CurrencyManagmentDbProperties.ConnectionStringName)]
public interface ICurrencyManagmentDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
