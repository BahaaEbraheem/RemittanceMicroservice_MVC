using Volo.Abp;
using Volo.Abp.MongoDB;

namespace CurrencyManagment.MongoDB;

public static class CurrencyManagmentMongoDbContextExtensions
{
    public static void ConfigureCurrencyManagment(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
