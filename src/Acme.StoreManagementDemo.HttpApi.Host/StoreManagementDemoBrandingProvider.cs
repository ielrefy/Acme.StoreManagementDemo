using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.StoreManagementDemo;

[Dependency(ReplaceServices = true)]
public class StoreManagementDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StoreManagementDemo";
}
