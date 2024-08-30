using Volo.Abp.Settings;

namespace Acme.StoreManagementDemo.Settings;

public class StoreManagementDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StoreManagementDemoSettings.MySetting1));
    }
}
