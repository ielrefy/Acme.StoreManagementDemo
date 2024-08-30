using Acme.StoreManagementDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Acme.StoreManagementDemo.Permissions;

public class StoreManagementDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StoreManagementDemoPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(StoreManagementDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StoreManagementDemoResource>(name);
    }
}
