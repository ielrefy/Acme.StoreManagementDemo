using Volo.Abp.Modularity;

namespace Acme.StoreManagementDemo;

public abstract class StoreManagementDemoApplicationTestBase<TStartupModule> : StoreManagementDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
