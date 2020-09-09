using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace OrderPullService.MongoDB
{
    [ConnectionStringName(OrderPullServiceDbProperties.ConnectionStringName)]
    public interface IOrderPullServiceMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
