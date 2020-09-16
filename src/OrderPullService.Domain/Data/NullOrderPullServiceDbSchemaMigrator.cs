using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OrderPullService.Data
{
    /* This is used if database provider does't define
     * IAgentManagementDbSchemaMigrator implementation.
     */
    public class NullOrderPullServiceDbSchemaMigrator : IOrderPullServiceDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync(string connectionString = null)
        {
            return Task.CompletedTask;
        }
    }
}