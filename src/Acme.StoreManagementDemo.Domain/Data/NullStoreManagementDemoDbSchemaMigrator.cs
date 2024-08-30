using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.StoreManagementDemo.Data;

/* This is used if database provider does't define
 * IStoreManagementDemoDbSchemaMigrator implementation.
 */
public class NullStoreManagementDemoDbSchemaMigrator : IStoreManagementDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
