using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CurrencyManagment.EntityFrameworkCore;

[DependsOn(
    typeof(CurrencyManagmentDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class CurrencyManagmentEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<CurrencyManagmentDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
