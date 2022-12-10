using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace CurrencyManagment.MongoDB;

[ConnectionStringName(CurrencyManagmentDbProperties.ConnectionStringName)]
public interface ICurrencyManagmentMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
