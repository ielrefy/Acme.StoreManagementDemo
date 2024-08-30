using Volo.Abp.Modularity;

namespace Acme.StoreManagementDemo;

/* Inherit from this class for your domain layer tests. */
public abstract class StoreManagementDemoDomainTestBase<TStartupModule> : StoreManagementDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
