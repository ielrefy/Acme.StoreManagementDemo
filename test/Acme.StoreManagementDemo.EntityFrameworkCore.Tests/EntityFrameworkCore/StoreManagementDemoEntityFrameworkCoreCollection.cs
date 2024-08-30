using Xunit;

namespace Acme.StoreManagementDemo.EntityFrameworkCore;

[CollectionDefinition(StoreManagementDemoTestConsts.CollectionDefinitionName)]
public class StoreManagementDemoEntityFrameworkCoreCollection : ICollectionFixture<StoreManagementDemoEntityFrameworkCoreFixture>
{

}
