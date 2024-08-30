using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.StoreManagementDemo.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.StoreManagementDemo.EntityFrameworkCore;

public class EntityFrameworkCoreStoreManagementDemoDbSchemaMigrator
    : IStoreManagementDemoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreStoreManagementDemoDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the StoreManagementDemoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StoreManagementDemoDbContext>()
            .Database
            .MigrateAsync();
    }
}
