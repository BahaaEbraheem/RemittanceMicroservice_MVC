using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace CustomerManagement.MongoDB;

[ConnectionStringName(CustomerManagementDbProperties.ConnectionStringName)]
public interface ICustomerManagementMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
