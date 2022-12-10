using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CurrencyManagment.EntityFrameworkCore;

public class CurrencyManagmentHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<CurrencyManagmentHttpApiHostMigrationsDbContext>
{
    public CurrencyManagmentHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<CurrencyManagmentHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("CurrencyManagment"));

        return new CurrencyManagmentHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
