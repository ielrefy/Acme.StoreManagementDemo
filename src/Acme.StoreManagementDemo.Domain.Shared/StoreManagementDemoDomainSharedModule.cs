using Acme.StoreManagementDemo.Localization;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.OpenIddict;
using Volo.Abp.BlobStoring.Database;
using Volo.Abp.TenantManagement;

namespace Acme.StoreManagementDemo;

[DependsOn(
    typeof(AbpAuditLoggingDomainSharedModule),
    typeof(AbpBackgroundJobsDomainSharedModule),
    typeof(AbpFeatureManagementDomainSharedModule),
    typeof(AbpPermissionManagementDomainSharedModule),
    typeof(AbpSettingManagementDomainSharedModule),
    typeof(AbpIdentityDomainSharedModule),
    typeof(AbpOpenIddictDomainSharedModule),
    typeof(AbpTenantManagementDomainSharedModule),
    typeof(BlobStoringDatabaseDomainSharedModule)
    )]
public class StoreManagementDemoDomainSharedModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        StoreManagementDemoGlobalFeatureConfigurator.Configure();
        StoreManagementDemoModuleExtensionConfigurator.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<StoreManagementDemoDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<StoreManagementDemoResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/StoreManagementDemo");

            options.DefaultResourceType = typeof(StoreManagementDemoResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("StoreManagementDemo", typeof(StoreManagementDemoResource));
        });
    }
}
