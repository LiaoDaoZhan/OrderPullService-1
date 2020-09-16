using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;

namespace OrderPullService.EntityFrameworkCore
{
    [ConnectionStringName(OrderPullServiceDbProperties.ConnectionStringName)]
    public class OrderPullServiceMigrationDbContext : AbpDbContext<OrderPullServiceMigrationDbContext>
    {
        public OrderPullServiceMigrationDbContext(
            DbContextOptions<OrderPullServiceMigrationDbContext> options
            ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureOrderPullService();
        }
    }
}
