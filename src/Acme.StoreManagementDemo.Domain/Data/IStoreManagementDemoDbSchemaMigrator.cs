using System.Threading.Tasks;

namespace Acme.StoreManagementDemo.Data;

public interface IStoreManagementDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
