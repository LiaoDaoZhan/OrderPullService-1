using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace OrderPullService.MongoDB
{
    public static class OrderPullServiceMongoDbContextExtensions
    {
        public static void ConfigureOrderPullService(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new OrderPullServiceMongoModelBuilderConfigurationOptions(
                OrderPullServiceDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}