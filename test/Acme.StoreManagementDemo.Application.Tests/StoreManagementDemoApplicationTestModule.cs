using Volo.Abp.Modularity;

namespace Acme.StoreManagementDemo;

[DependsOn(
    typeof(StoreManagementDemoApplicationModule),
    typeof(StoreManagementDemoDomainTestModule)
)]
public class StoreManagementDemoApplicationTestModule : AbpModule
{

}
