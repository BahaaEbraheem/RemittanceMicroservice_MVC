using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace RemittanceManagement.MongoDB;

[ConnectionStringName(RemittanceManagementDbProperties.ConnectionStringName)]
public interface IRemittanceManagementMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
