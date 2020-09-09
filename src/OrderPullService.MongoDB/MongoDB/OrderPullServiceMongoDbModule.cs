using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace OrderPullService.MongoDB
{
    [DependsOn(
        typeof(OrderPullServiceDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class OrderPullServiceMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<OrderPullServiceMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
