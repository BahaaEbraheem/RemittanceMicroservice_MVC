using Volo.Abp;
using Volo.Abp.MongoDB;

namespace RemittanceManagement.MongoDB;

public static class RemittanceManagementMongoDbContextExtensions
{
    public static void ConfigureRemittanceManagement(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
