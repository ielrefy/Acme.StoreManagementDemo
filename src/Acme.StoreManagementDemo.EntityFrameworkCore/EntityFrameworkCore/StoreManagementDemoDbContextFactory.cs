using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.StoreManagementDemo.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class StoreManagementDemoDbContextFactory : IDesignTimeDbContextFactory<StoreManagementDemoDbContext>
{
    public StoreManagementDemoDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        StoreManagementDemoEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<StoreManagementDemoDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new StoreManagementDemoDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.StoreManagementDemo.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
