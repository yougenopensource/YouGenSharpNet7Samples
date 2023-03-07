/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Data;
using Oracle.ManagedDataAccess.Types;
using Oracle.ManagedDataAccess.Client;
using XE_HR_BackEndDatabaseClient;
using XE_HR_BackEndCommon.Configuration;
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_BackEndCommon.RequestHandlers;
using XE_HR_BackEndCommon.Services;
using XE_HR_Common.Validators;
using XE_HR_BackEndCommon.IndirectReferenceTransformers;
using XE_HR_BackEndCoreWCFServer.Services;
namespace XE_HR_BackEndCoreWCFServer;
public class Program
{
    public static void Main()
    {
        WebApplicationBuilder builder;
        EnvironmentSettings environmentSettings;
        CustomAppSettings customAppSettings;
        WebApplication app;
        // Configure the web app builder
        builder = WebApplication.CreateBuilder();
        builder.Logging.ClearProviders();
		builder.Logging.AddJsonConsole(jsonConsoleFormatterOptions =>
        {
            jsonConsoleFormatterOptions.JsonWriterOptions = new()
            {
                Indented = true
            };
        });
        builder.Configuration.SetBasePath(builder.Environment.ContentRootPath);
        // Load and configure default or custom configuration files 
        // Determine runtime environment and load appropriate configurations
        // The runtime environment is set as an visual studio environment variable defaulted at Development for the launch profiles of this app in debug mode
        // On Physical/Virtual hosts running this app after publish you will need to set an environment variable named ASPNETCORE_ENVIRONMENT with one of the below environment values
        // On Azure App Services, you will need an AppSetting named ASPNETCORE_ENVIRONMENT with one of the below environment values
        if (builder.Environment.IsDevelopment())
        {
            builder.Configuration.AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true);
        }
        else if (builder.Environment.IsEnvironment("QualityAssurance"))
        {
            builder.Configuration.AddJsonFile("appsettings.QualityAssurance.json", optional: false, reloadOnChange: true);
        }
        else if (builder.Environment.IsEnvironment("Staging"))
        {
            builder.Configuration.AddJsonFile("appsettings.Staging.json", optional: false, reloadOnChange: true);
        }
        else
        {
            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        }
        // Create and load the environment settings
        environmentSettings = new EnvironmentSettings();
        // Retrieve the environment variables
        builder.Configuration.AddEnvironmentVariables();
        // Retrieve the loaded config file(s)
        environmentSettings.RuntimeEnvironment = builder.Environment.EnvironmentName;
        environmentSettings.MachineName = Environment.MachineName;
        environmentSettings.CustomAppSettingsOverrides.DbConnection = Environment.GetEnvironmentVariable("DbConnection", EnvironmentVariableTarget.Machine);
        environmentSettings.CustomAppSettingsOverrides.SelfRootUri = Environment.GetEnvironmentVariable("SelfRootUri", EnvironmentVariableTarget.Machine);
        environmentSettings.CustomAppSettingsOverrides.EncryptDecryptKey = Environment.GetEnvironmentVariable("EncryptDecryptKey", EnvironmentVariableTarget.Machine);
        // Set custom app settings manual overrides as necessary
        customAppSettings = builder.Configuration.GetRequiredSection("CustomAppSettings")?.Get<CustomAppSettings>()!;
        if (!String.IsNullOrEmpty(environmentSettings.CustomAppSettingsOverrides.DbConnection))
            customAppSettings!.DbConnection = environmentSettings.CustomAppSettingsOverrides.DbConnection;
        if (!String.IsNullOrEmpty(environmentSettings.CustomAppSettingsOverrides.SelfRootUri))
            customAppSettings!.SelfRootUri = environmentSettings.CustomAppSettingsOverrides.SelfRootUri;
        if (!String.IsNullOrEmpty(environmentSettings.CustomAppSettingsOverrides.EncryptDecryptKey))
            customAppSettings!.EncryptDecryptKey = environmentSettings.CustomAppSettingsOverrides.EncryptDecryptKey;
        // Register the settings for dependency injection
        builder.Services.AddSingleton(environmentSettings);
        builder.Services.AddSingleton(customAppSettings!);
        // Add services to the container.
        // Configure ef core dbcontext        
		// builder.Services.AddDbContext<XE_HR_Context>(options =>
		//     options.UseInMemoryDatabase("XE_HR"
		//     )); 
		builder.Services.AddDbContext<XE_HR_Context>(options =>
		     options.UseOracle(customAppSettings!.DbConnection!));
		builder.Services.AddSingleton<IDbConnection>(s => new OracleConnection(customAppSettings!.DbConnection!));
		builder.Services.AddSingleton<IEncryptionDecryptionService>(opt => new EncryptionDecryptionService(customAppSettings!.EncryptDecryptKey!));
		builder.Services.AddSingleton<IIRTransformers,IRTransformers>();
		builder.Services.AddScoped<IXE_HR_COUNTRIES_Repository,XE_HR_COUNTRIES_Repository>();
		builder.Services.AddScoped<IXE_HR_DEPARTMENTS_Repository,XE_HR_DEPARTMENTS_Repository>();
		builder.Services.AddScoped<IXE_HR_EMPLOYEES_Repository,XE_HR_EMPLOYEES_Repository>();
		builder.Services.AddScoped<IXE_HR_JOB_HISTORY_Repository,XE_HR_JOB_HISTORY_Repository>();
		builder.Services.AddScoped<IXE_HR_JOBS_Repository,XE_HR_JOBS_Repository>();
		builder.Services.AddScoped<IXE_HR_LOCATIONS_Repository,XE_HR_LOCATIONS_Repository>();
		builder.Services.AddScoped<IXE_HR_REGIONS_Repository,XE_HR_REGIONS_Repository>();
		builder.Services.AddScoped<IXE_HR_EMP_DETAILS_VIEW_Repository,XE_HR_EMP_DETAILS_VIEW_Repository>();
		builder.Services.AddScoped<XE_HR_EMP_DETAILS_VIEW_Service>();
		builder.Services.AddScoped<IXE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_StoredProcedure_Repository,XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_StoredProcedure_Repository>();
		builder.Services.AddScoped<IXE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Repository,XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Repository>();
		builder.Services.AddScoped<IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Repository,XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Repository>();
		builder.Services.AddScoped<IXE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_Repository,XE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_Repository>();
		builder.Services.AddScoped<IXE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Repository,XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Repository>();
		builder.Services.AddScoped<IGenericRepository<XE_HR_COUNTRIES>,GenericRepository<XE_HR_COUNTRIES>>();
		builder.Services.AddScoped<IGenericRepository<XE_HR_DEPARTMENTS>,GenericRepository<XE_HR_DEPARTMENTS>>();
		builder.Services.AddScoped<IGenericRepository<XE_HR_EMPLOYEES>,GenericRepository<XE_HR_EMPLOYEES>>();
		builder.Services.AddScoped<IGenericRepository<XE_HR_JOB_HISTORY>,GenericRepository<XE_HR_JOB_HISTORY>>();
		builder.Services.AddScoped<IGenericRepository<XE_HR_JOBS>,GenericRepository<XE_HR_JOBS>>();
		builder.Services.AddScoped<IGenericRepository<XE_HR_LOCATIONS>,GenericRepository<XE_HR_LOCATIONS>>();
		builder.Services.AddScoped<IGenericRepository<XE_HR_REGIONS>,GenericRepository<XE_HR_REGIONS>>();
		builder.Services.AddScoped<IGenericRepository<XE_HR_EMP_DETAILS_VIEW>,GenericRepository<XE_HR_EMP_DETAILS_VIEW>>();
		builder.Services.AddScoped<IGenericTableRepository<XE_HR_COUNTRIES>,GenericTableRepository<XE_HR_COUNTRIES>>();
		builder.Services.AddScoped<IGenericTableRepository<XE_HR_DEPARTMENTS>,GenericTableRepository<XE_HR_DEPARTMENTS>>();
		builder.Services.AddScoped<IGenericTableRepository<XE_HR_EMPLOYEES>,GenericTableRepository<XE_HR_EMPLOYEES>>();
		builder.Services.AddScoped<IGenericTableRepository<XE_HR_JOB_HISTORY>,GenericTableRepository<XE_HR_JOB_HISTORY>>();
		builder.Services.AddScoped<IGenericTableRepository<XE_HR_JOBS>,GenericTableRepository<XE_HR_JOBS>>();
		builder.Services.AddScoped<IGenericTableRepository<XE_HR_LOCATIONS>,GenericTableRepository<XE_HR_LOCATIONS>>();
		builder.Services.AddScoped<IGenericTableRepository<XE_HR_REGIONS>,GenericTableRepository<XE_HR_REGIONS>>();
		builder.Services.AddScoped<IXE_HR_COUNTRIES_RequestHandler,XE_HR_COUNTRIES_RequestHandler>();
		builder.Services.AddScoped<IXE_HR_DEPARTMENTS_RequestHandler,XE_HR_DEPARTMENTS_RequestHandler>();
		builder.Services.AddScoped<IXE_HR_EMPLOYEES_RequestHandler,XE_HR_EMPLOYEES_RequestHandler>();
		builder.Services.AddScoped<IXE_HR_JOB_HISTORY_RequestHandler,XE_HR_JOB_HISTORY_RequestHandler>();
		builder.Services.AddScoped<IXE_HR_JOBS_RequestHandler,XE_HR_JOBS_RequestHandler>();
		builder.Services.AddScoped<IXE_HR_LOCATIONS_RequestHandler,XE_HR_LOCATIONS_RequestHandler>();
		builder.Services.AddScoped<IXE_HR_REGIONS_RequestHandler,XE_HR_REGIONS_RequestHandler>();
		builder.Services.AddScoped<IXE_HR_EMP_DETAILS_VIEW_RequestHandler,XE_HR_EMP_DETAILS_VIEW_RequestHandler>();
		builder.Services.AddScoped<IXE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_StoredProcedure_RequestHandler,XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_StoredProcedure_RequestHandler>();
		builder.Services.AddScoped<IXE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_RequestHandler,XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_RequestHandler>();
		builder.Services.AddScoped<IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_RequestHandler,XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_RequestHandler>();
		builder.Services.AddScoped<IXE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_RequestHandler,XE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_RequestHandler>();
		builder.Services.AddScoped<IXE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_RequestHandler,XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_RequestHandler>();
		builder.Services.AddScoped<XE_HR_COUNTRIES_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_COUNTRIES_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_COUNTRIES_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_COUNTRIES_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<XE_HR_DEPARTMENTS_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_DEPARTMENTS_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_DEPARTMENTS_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_DEPARTMENTS_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<XE_HR_EMPLOYEES_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_EMPLOYEES_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_EMPLOYEES_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_EMPLOYEES_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<XE_HR_JOB_HISTORY_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_JOB_HISTORY_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_JOB_HISTORY_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_JOB_HISTORY_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<XE_HR_JOBS_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_JOBS_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_JOBS_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_JOBS_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<XE_HR_LOCATIONS_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_LOCATIONS_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_LOCATIONS_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_LOCATIONS_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<XE_HR_REGIONS_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_REGIONS_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_REGIONS_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_REGIONS_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<XE_HR_EMP_DETAILS_VIEW_IR_FluentValidator>();
		builder.Services.AddScoped<XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_IM_IR_FluentValidator>();
		builder.Services.AddScoped<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR_FluentValidator>();
		builder.Services.AddScoped<XE_HR_PACKAGE1_PARAMOUTCURSORS_IM_IR_FluentValidator>();
		builder.Services.AddScoped<XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR_FluentValidator>();
		builder.Services.AddScoped<XE_HR_COUNTRIES_Service>();
		builder.Services.AddScoped<XE_HR_DEPARTMENTS_Service>();
		builder.Services.AddScoped<XE_HR_EMPLOYEES_Service>();
		builder.Services.AddScoped<XE_HR_JOB_HISTORY_Service>();
		builder.Services.AddScoped<XE_HR_JOBS_Service>();
		builder.Services.AddScoped<XE_HR_LOCATIONS_Service>();
		builder.Services.AddScoped<XE_HR_REGIONS_Service>();
		builder.Services.AddScoped<XE_HR_EMP_DETAILS_VIEW_Service>();
		builder.Services.AddScoped<XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_StoredProcedure_Service>();
		builder.Services.AddScoped<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Service>();
		builder.Services.AddScoped<XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service>();
		builder.Services.AddScoped<XE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_Service>();
		builder.Services.AddScoped<XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Service>();
        //configure WCF services
        builder.Services.AddServiceModelServices();
        builder.Services.AddServiceModelMetadata();
        builder.Services.AddSingleton<IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();
        // Build the app
        app = builder.Build();
        // Register Service Endpoints
        app.UseServiceModel(serviceBuilder =>
        {
			var basicBinding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
			serviceBuilder.AddService<XE_HR_COUNTRIES_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_COUNTRIES_Service, IXE_HR_COUNTRIES_Service>(basicBinding, "/XE_HR_COUNTRIES_Service");
			serviceBuilder.AddService<XE_HR_DEPARTMENTS_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_DEPARTMENTS_Service, IXE_HR_DEPARTMENTS_Service>(basicBinding, "/XE_HR_DEPARTMENTS_Service");
			serviceBuilder.AddService<XE_HR_EMPLOYEES_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_EMPLOYEES_Service, IXE_HR_EMPLOYEES_Service>(basicBinding, "/XE_HR_EMPLOYEES_Service");
			serviceBuilder.AddService<XE_HR_JOB_HISTORY_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_JOB_HISTORY_Service, IXE_HR_JOB_HISTORY_Service>(basicBinding, "/XE_HR_JOB_HISTORY_Service");
			serviceBuilder.AddService<XE_HR_JOBS_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_JOBS_Service, IXE_HR_JOBS_Service>(basicBinding, "/XE_HR_JOBS_Service");
			serviceBuilder.AddService<XE_HR_LOCATIONS_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_LOCATIONS_Service, IXE_HR_LOCATIONS_Service>(basicBinding, "/XE_HR_LOCATIONS_Service");
			serviceBuilder.AddService<XE_HR_REGIONS_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_REGIONS_Service, IXE_HR_REGIONS_Service>(basicBinding, "/XE_HR_REGIONS_Service");
			serviceBuilder.AddService<XE_HR_EMP_DETAILS_VIEW_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_EMP_DETAILS_VIEW_Service, IXE_HR_EMP_DETAILS_VIEW_Service>(basicBinding, "/XE_HR_EMP_DETAILS_VIEW_Service");
			serviceBuilder.AddService<XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_StoredProcedure_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_StoredProcedure_Service, IXE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_StoredProcedure_Service>(basicBinding, "/XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_StoredProcedure_Service");
			serviceBuilder.AddService<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Service, IXE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Service>(basicBinding, "/XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Service");
			serviceBuilder.AddService<XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service, IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service>(basicBinding, "/XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service");
			serviceBuilder.AddService<XE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_Service, IXE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_Service>(basicBinding, "/XE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_Service");
			serviceBuilder.AddService<XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Service>();
			serviceBuilder.AddServiceEndpoint<XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Service, IXE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Service>(basicBinding, "/XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Service");
            var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
            serviceMetadataBehavior.HttpsGetEnabled = true;
        });
        // Run the app
        app.Run();
    }
}
