using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RemittanceManagement.EntityFrameworkCore;

public class RemittanceManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<RemittanceManagementHttpApiHostMigrationsDbContext>
{
    public RemittanceManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<RemittanceManagementHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("RemittanceManagement"));

        return new RemittanceManagementHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
