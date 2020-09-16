using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OrderPullService.Data
{
    public interface IOrderPullServiceDbSchemaMigrator
    {
        Task MigrateAsync(string connectionString = null);
    }
}
