using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OrderPullService.EntityFrameworkCore
{
    public class OrderPullServiceHttpApiHostMigrationsDbContext : AbpDbContext<OrderPullServiceHttpApiHostMigrationsDbContext>
    {
        public OrderPullServiceHttpApiHostMigrationsDbContext(DbContextOptions<OrderPullServiceHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureOrderPullService();
        }
    }
}
