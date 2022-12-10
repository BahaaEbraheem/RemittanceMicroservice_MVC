using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace CurrencyManagment.MongoDB;

[DependsOn(
    typeof(CurrencyManagmentDomainModule),
    typeof(AbpMongoDbModule)
    )]
public class CurrencyManagmentMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<CurrencyManagmentMongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
