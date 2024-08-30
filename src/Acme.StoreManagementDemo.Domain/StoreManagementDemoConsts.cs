using Volo.Abp.Identity;

namespace Acme.StoreManagementDemo;

public static class StoreManagementDemoConsts
{
    public const string DbTablePrefix = "App";
    public const string? DbSchema = null;
    public const string AdminEmailDefaultValue = IdentityDataSeedContributor.AdminEmailDefaultValue;
    public const string AdminPasswordDefaultValue = IdentityDataSeedContributor.AdminPasswordDefaultValue;
    public const int MaxNameLength = 30;
    public const int MaxDescriptionLength = 100;
}
