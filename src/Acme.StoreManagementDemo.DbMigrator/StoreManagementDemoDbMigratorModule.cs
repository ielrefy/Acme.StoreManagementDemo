using Acme.StoreManagementDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.StoreManagementDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StoreManagementDemoEntityFrameworkCoreModule),
    typeof(StoreManagementDemoApplicationContractsModule)
)]
public class StoreManagementDemoDbMigratorModule : AbpModule
{
}
