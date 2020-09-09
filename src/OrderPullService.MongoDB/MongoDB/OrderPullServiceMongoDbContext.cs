using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace OrderPullService.MongoDB
{
    [ConnectionStringName(OrderPullServiceDbProperties.ConnectionStringName)]
    public class OrderPullServiceMongoDbContext : AbpMongoDbContext, IOrderPullServiceMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureOrderPullService();
        }
    }
}