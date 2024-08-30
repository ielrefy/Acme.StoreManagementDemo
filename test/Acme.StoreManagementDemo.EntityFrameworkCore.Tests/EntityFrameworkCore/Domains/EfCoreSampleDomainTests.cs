using Acme.StoreManagementDemo.Samples;
using Xunit;

namespace Acme.StoreManagementDemo.EntityFrameworkCore.Domains;

[Collection(StoreManagementDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StoreManagementDemoEntityFrameworkCoreTestModule>
{

}
