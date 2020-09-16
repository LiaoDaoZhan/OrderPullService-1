using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace OrderPullService.EntityFrameworkCore
{
    [ConnectionStringName(OrderPullServiceDbProperties.ConnectionStringName)]
    public interface IOrderPullServiceDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Shop> Shops { get; }
        DbSet<Trade> Trades { get; }

        DbSet<TradeDetail> TradeDetails { get; }
    }
}