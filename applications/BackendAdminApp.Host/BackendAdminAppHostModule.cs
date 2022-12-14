using System;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using ProductManagement;
using StackExchange.Redis;
using Microsoft.OpenApi.Models;
using MsDemo.Shared;
using Volo.Abp;
using Volo.Abp.AspNetCore.Authentication.OAuth;
using Volo.Abp.AspNetCore.Mvc.Client;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.Autofac;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Http.Client.IdentityModel.Web;
using Volo.Abp.Identity;
using Volo.Abp.Identity.Web;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.Web;
using Volo.Abp.UI.Navigation;
using Volo.Blogging;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Volo.Abp.Http.Client.Web;
using CurrencyManagment.Web;
using CurrencyManagment;
using CustomerManagement;
using CustomerManagement.Web;
using RemittanceManagement.Web;
using RemittanceManagement;
using Volo.Abp.PermissionManagement.Web;
using Volo.Abp.Http.Client.IdentityModel;
//using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using Volo.Abp.UI.Navigation.Urls;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Account;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.Account.Web;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Volo.Abp.Http.Client;
//using Volo.Abp.EntityFrameworkCore.SqlServer;

namespace BackendAdminApp.Host
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpAspNetCoreMvcClientModule),
        typeof(AbpAspNetCoreAuthenticationOAuthModule),
        typeof(AbpHttpClientIdentityModelWebModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(AbpIdentityWebModule),
        typeof(AbpTenantManagementHttpApiClientModule),
        typeof(AbpTenantManagementWebModule),
        typeof(BloggingApplicationContractsModule),

        //typeof(AbpPermissionManagementHttpApiClientModule),
        typeof(AbpPermissionManagementWebModule),

        typeof(ProductManagementHttpApiClientModule),
        typeof(ProductManagementWebModule),

        typeof(CurrencyManagmentHttpApiClientModule),
        typeof(CurrencyManagmentWebModule),

        typeof(RemittanceManagementHttpApiClientModule),
        typeof(RemittanceManagementWebModule),

        typeof(CustomerManagementHttpApiClientModule),
        typeof(CustomerManagementWebModule),

        typeof(AbpAspNetCoreMvcUiBasicThemeModule),
        typeof(AbpFeatureManagementHttpApiClientModule),

        typeof(AbpHttpClientWebModule),
        typeof(AbpHttpClientIdentityModelModule),
     typeof(AbpIdentityHttpApiModule),
        typeof(AbpAspNetCoreMvcContractsModule),
        typeof(AbpTenantManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcUiMultiTenancyModule),
        typeof(AbpIdentityApplicationContractsModule),
        typeof(AbpIdentityServerEntityFrameworkCoreModule),
        typeof(AbpAccountWebIdentityServerModule),



             typeof(AbpHttpClientModule)



        //typeof(AbpAccountApplicationModule)

        )]
        public class BackendAdminAppHostModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();


            Configure<AbpLocalizationOptions>(options =>
            {
                options.Languages.Add(new LanguageInfo("en", "en", "English"));
            });

            Configure<AbpMultiTenancyOptions>(options =>
            {
                options.IsEnabled = MsDemoConsts.IsMultiTenancyEnabled;
            });

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new BackendAdminAppMenuContributor(configuration));
            });

            context.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = "Cookies";
                options.DefaultChallengeScheme = "oidc";
            })
                .AddCookie("Cookies", options =>
                {
                    options.ExpireTimeSpan = TimeSpan.FromDays(365);
                })
                .AddOpenIdConnect("oidc", options =>
                {
                    options.Authority = configuration["AuthServer:Authority"];
                    options.ClientId = configuration["AuthServer:ClientId"];
                    options.ClientSecret = configuration["AuthServer:ClientSecret"];
                    options.RequireHttpsMetadata = Convert.ToBoolean(configuration["AuthServer:RequireHttpsMetadata"]);
                    options.ResponseType = OpenIdConnectResponseType.CodeIdToken;
                    options.SaveTokens = true;
                    options.GetClaimsFromUserInfoEndpoint = true;
                    options.Scope.Add("role");
                    options.Scope.Add("email");
                    options.Scope.Add("phone");
                    options.Scope.Add("BackendAdminAppGateway");
                    options.Scope.Add("IdentityService");
                    options.Scope.Add("ProductService");
                    options.Scope.Add("TenantManagementService");

                });

            context.Services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Backend Admin Application API", Version = "v1" });
                    options.DocInclusionPredicate((docName, description) => true);
                });

            context.Services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration["Redis:Configuration"];
            });

            var redis = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]);
            context.Services.AddDataProtection()
                .PersistKeysToStackExchangeRedis(redis, "MsDemo-DataProtection-Keys");
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
        
             app.UseCorrelationId();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();

            if (MsDemoConsts.IsMultiTenancyEnabled)
            {
                app.UseMultiTenancy();
            }

            app.UseAbpRequestLocalization();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Backend Admin Application API");
            });
            app.UseConfiguredEndpoints();
        }
    }
}
