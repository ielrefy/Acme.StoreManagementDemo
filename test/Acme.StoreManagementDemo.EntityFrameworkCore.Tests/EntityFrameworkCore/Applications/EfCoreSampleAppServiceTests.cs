using Acme.StoreManagementDemo.Samples;
using Xunit;

namespace Acme.StoreManagementDemo.EntityFrameworkCore.Applications;

[Collection(StoreManagementDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StoreManagementDemoEntityFrameworkCoreTestModule>
{

}
