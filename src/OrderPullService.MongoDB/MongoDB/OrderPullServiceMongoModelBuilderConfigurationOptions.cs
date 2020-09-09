using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace OrderPullService.MongoDB
{
    public class OrderPullServiceMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public OrderPullServiceMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}