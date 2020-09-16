using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;
using Microsoft.Extensions.DependencyInjection;
using OrderPullService.Data;

namespace OrderPullService.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreOrderPullServiceDbSchemaMigrator : IOrderPullServiceDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreOrderPullServiceDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public async Task MigrateAsync(string connectionString = null)
        {
            /* We intentionally resolving the CSA_ToolsMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<OrderPullServiceMigrationDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
