using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace OrderPullService.EntityFrameworkCore
{
    public class OrderPullServiceModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public OrderPullServiceModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}