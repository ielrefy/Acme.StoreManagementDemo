using Acme.StoreManagementDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.StoreManagementDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StoreManagementDemoController : AbpControllerBase
{
    protected StoreManagementDemoController()
    {
        LocalizationResource = typeof(StoreManagementDemoResource);
    }
}
