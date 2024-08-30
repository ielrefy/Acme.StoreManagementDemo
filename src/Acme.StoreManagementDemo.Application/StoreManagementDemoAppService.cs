using Acme.StoreManagementDemo.Localization;
using Volo.Abp.Application.Services;

namespace Acme.StoreManagementDemo;

/* Inherit your application services from this class.
 */
public abstract class StoreManagementDemoAppService : ApplicationService
{
    protected StoreManagementDemoAppService()
    {
        LocalizationResource = typeof(StoreManagementDemoResource);
    }
}
