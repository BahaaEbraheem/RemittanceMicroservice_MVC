using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace CurrencyManagment.MongoDB;

[ConnectionStringName(CurrencyManagmentDbProperties.ConnectionStringName)]
public class CurrencyManagmentMongoDbContext : AbpMongoDbContext, ICurrencyManagmentMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureCurrencyManagment();
    }
}
