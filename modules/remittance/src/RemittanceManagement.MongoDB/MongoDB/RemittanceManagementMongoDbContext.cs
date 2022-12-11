using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace RemittanceManagement.MongoDB;

[ConnectionStringName(RemittanceManagementDbProperties.ConnectionStringName)]
public class RemittanceManagementMongoDbContext : AbpMongoDbContext, IRemittanceManagementMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureRemittanceManagement();
    }
}
