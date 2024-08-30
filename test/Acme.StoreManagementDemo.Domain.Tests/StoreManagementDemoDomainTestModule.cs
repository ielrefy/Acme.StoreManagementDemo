using Volo.Abp.Modularity;

namespace Acme.StoreManagementDemo;

[DependsOn(
    typeof(StoreManagementDemoDomainModule),
    typeof(StoreManagementDemoTestBaseModule)
)]
public class StoreManagementDemoDomainTestModule : AbpModule
{

}
