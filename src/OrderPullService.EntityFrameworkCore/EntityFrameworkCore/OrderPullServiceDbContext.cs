using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace OrderPullService.EntityFrameworkCore
{
    [ConnectionStringName(OrderPullServiceDbProperties.ConnectionStringName)]
    public class OrderPullServiceDbContext : AbpDbContext<OrderPullServiceDbContext>, IOrderPullServiceDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public OrderPullServiceDbContext(DbContextOptions<OrderPullServiceDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureOrderPullService();
        }
    }
}