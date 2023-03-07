/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Northwind_BackEndDatabaseClient;
using Northwind_BackEndCommon.Configuration;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_BackEndCommon.RequestHandlers;
using Northwind_BackEndCommon.Services;
using Northwind_Common.Validators;
using Northwind_BackEndCommon.IndirectReferenceTransformers;
using Northwind_BackEndSignalRWebsocketServer.Hubs;
namespace Northwind_BackEndSignalRWebsocketServer;
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
        // !!!! Change the below before exposing this to the internet !!!!!
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowSpecificOrigin",
                builder =>
                builder
                    //.AllowCredentials()
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowedToAllowWildcardSubdomains());
        });
         var contractResolver = new DefaultContractResolver
        {
            NamingStrategy = new DefaultNamingStrategy()
        };
		builder.Services.AddSignalR()
        .AddNewtonsoftJsonProtocol(options => { 
			options.PayloadSerializerSettings.ContractResolver = contractResolver;
			options.PayloadSerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
		});
        // Configure ef core dbcontext        
		// builder.Services.AddDbContext<Northwind_Context>(options =>
		//     options.UseInMemoryDatabase("Northwind",
		//         opt => opt.UseHierarchyId()
		//     )); 
		builder.Services.AddDbContext<Northwind_Context>(options =>
		     options.UseSqlServer(customAppSettings!.DbConnection!,
		         opt => opt.UseHierarchyId()
		     )); 
		builder.Services.AddSingleton<IEncryptionDecryptionService>(opt => new EncryptionDecryptionService(customAppSettings!.EncryptDecryptKey!));
		builder.Services.AddSingleton<IIRTransformers,IRTransformers>();
		builder.Services.AddScoped<INorthwind_dbo_Categories_Repository,Northwind_dbo_Categories_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_CustomerCustomerDemo_Repository,Northwind_dbo_CustomerCustomerDemo_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_CustomerDemographics_Repository,Northwind_dbo_CustomerDemographics_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Customers_Repository,Northwind_dbo_Customers_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Employees_Repository,Northwind_dbo_Employees_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_EmployeeTerritories_Repository,Northwind_dbo_EmployeeTerritories_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Order_Details_Repository,Northwind_dbo_Order_Details_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Orders_Repository,Northwind_dbo_Orders_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Products_Repository,Northwind_dbo_Products_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Region_Repository,Northwind_dbo_Region_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Shippers_Repository,Northwind_dbo_Shippers_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Suppliers_Repository,Northwind_dbo_Suppliers_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Territories_Repository,Northwind_dbo_Territories_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Alphabetical_list_of_products_Repository,Northwind_dbo_Alphabetical_list_of_products_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Category_Sales_for_1997_Repository,Northwind_dbo_Category_Sales_for_1997_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Current_Product_List_Repository,Northwind_dbo_Current_Product_List_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Customer_and_Suppliers_by_City_Repository,Northwind_dbo_Customer_and_Suppliers_by_City_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Invoices_Repository,Northwind_dbo_Invoices_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Order_Details_Extended_Repository,Northwind_dbo_Order_Details_Extended_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Order_Subtotals_Repository,Northwind_dbo_Order_Subtotals_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Orders_Qry_Repository,Northwind_dbo_Orders_Qry_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Product_Sales_for_1997_Repository,Northwind_dbo_Product_Sales_for_1997_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Products_Above_Average_Price_Repository,Northwind_dbo_Products_Above_Average_Price_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Products_by_Category_Repository,Northwind_dbo_Products_by_Category_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Quarterly_Orders_Repository,Northwind_dbo_Quarterly_Orders_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Sales_by_Category_Repository,Northwind_dbo_Sales_by_Category_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Sales_Totals_by_Amount_Repository,Northwind_dbo_Sales_Totals_by_Amount_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Summary_of_Sales_by_Quarter_Repository,Northwind_dbo_Summary_of_Sales_by_Quarter_Repository>();
		builder.Services.AddScoped<INorthwind_dbo_Summary_of_Sales_by_Year_Repository,Northwind_dbo_Summary_of_Sales_by_Year_Repository>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Categories>,GenericRepository<Northwind_dbo_Categories>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_CustomerCustomerDemo>,GenericRepository<Northwind_dbo_CustomerCustomerDemo>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_CustomerDemographics>,GenericRepository<Northwind_dbo_CustomerDemographics>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Customers>,GenericRepository<Northwind_dbo_Customers>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Employees>,GenericRepository<Northwind_dbo_Employees>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_EmployeeTerritories>,GenericRepository<Northwind_dbo_EmployeeTerritories>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Order_Details>,GenericRepository<Northwind_dbo_Order_Details>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Orders>,GenericRepository<Northwind_dbo_Orders>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Products>,GenericRepository<Northwind_dbo_Products>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Region>,GenericRepository<Northwind_dbo_Region>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Shippers>,GenericRepository<Northwind_dbo_Shippers>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Suppliers>,GenericRepository<Northwind_dbo_Suppliers>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Territories>,GenericRepository<Northwind_dbo_Territories>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Alphabetical_list_of_products>,GenericRepository<Northwind_dbo_Alphabetical_list_of_products>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Category_Sales_for_1997>,GenericRepository<Northwind_dbo_Category_Sales_for_1997>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Current_Product_List>,GenericRepository<Northwind_dbo_Current_Product_List>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Customer_and_Suppliers_by_City>,GenericRepository<Northwind_dbo_Customer_and_Suppliers_by_City>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Invoices>,GenericRepository<Northwind_dbo_Invoices>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Order_Details_Extended>,GenericRepository<Northwind_dbo_Order_Details_Extended>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Order_Subtotals>,GenericRepository<Northwind_dbo_Order_Subtotals>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Orders_Qry>,GenericRepository<Northwind_dbo_Orders_Qry>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Product_Sales_for_1997>,GenericRepository<Northwind_dbo_Product_Sales_for_1997>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Products_Above_Average_Price>,GenericRepository<Northwind_dbo_Products_Above_Average_Price>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Products_by_Category>,GenericRepository<Northwind_dbo_Products_by_Category>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Quarterly_Orders>,GenericRepository<Northwind_dbo_Quarterly_Orders>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Sales_by_Category>,GenericRepository<Northwind_dbo_Sales_by_Category>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Sales_Totals_by_Amount>,GenericRepository<Northwind_dbo_Sales_Totals_by_Amount>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Summary_of_Sales_by_Quarter>,GenericRepository<Northwind_dbo_Summary_of_Sales_by_Quarter>>();
		builder.Services.AddScoped<IGenericRepository<Northwind_dbo_Summary_of_Sales_by_Year>,GenericRepository<Northwind_dbo_Summary_of_Sales_by_Year>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_Categories>,GenericTableRepository<Northwind_dbo_Categories>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_CustomerCustomerDemo>,GenericTableRepository<Northwind_dbo_CustomerCustomerDemo>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_CustomerDemographics>,GenericTableRepository<Northwind_dbo_CustomerDemographics>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_Customers>,GenericTableRepository<Northwind_dbo_Customers>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_Employees>,GenericTableRepository<Northwind_dbo_Employees>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_EmployeeTerritories>,GenericTableRepository<Northwind_dbo_EmployeeTerritories>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_Order_Details>,GenericTableRepository<Northwind_dbo_Order_Details>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_Orders>,GenericTableRepository<Northwind_dbo_Orders>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_Products>,GenericTableRepository<Northwind_dbo_Products>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_Region>,GenericTableRepository<Northwind_dbo_Region>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_Shippers>,GenericTableRepository<Northwind_dbo_Shippers>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_Suppliers>,GenericTableRepository<Northwind_dbo_Suppliers>>();
		builder.Services.AddScoped<IGenericTableRepository<Northwind_dbo_Territories>,GenericTableRepository<Northwind_dbo_Territories>>();
		builder.Services.AddScoped<INorthwind_dbo_Categories_RequestHandler,Northwind_dbo_Categories_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_CustomerCustomerDemo_RequestHandler,Northwind_dbo_CustomerCustomerDemo_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_CustomerDemographics_RequestHandler,Northwind_dbo_CustomerDemographics_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Customers_RequestHandler,Northwind_dbo_Customers_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Employees_RequestHandler,Northwind_dbo_Employees_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_EmployeeTerritories_RequestHandler,Northwind_dbo_EmployeeTerritories_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Order_Details_RequestHandler,Northwind_dbo_Order_Details_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Orders_RequestHandler,Northwind_dbo_Orders_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Products_RequestHandler,Northwind_dbo_Products_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Region_RequestHandler,Northwind_dbo_Region_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Shippers_RequestHandler,Northwind_dbo_Shippers_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Suppliers_RequestHandler,Northwind_dbo_Suppliers_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Territories_RequestHandler,Northwind_dbo_Territories_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Alphabetical_list_of_products_RequestHandler,Northwind_dbo_Alphabetical_list_of_products_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Category_Sales_for_1997_RequestHandler,Northwind_dbo_Category_Sales_for_1997_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Current_Product_List_RequestHandler,Northwind_dbo_Current_Product_List_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Customer_and_Suppliers_by_City_RequestHandler,Northwind_dbo_Customer_and_Suppliers_by_City_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Invoices_RequestHandler,Northwind_dbo_Invoices_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Order_Details_Extended_RequestHandler,Northwind_dbo_Order_Details_Extended_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Order_Subtotals_RequestHandler,Northwind_dbo_Order_Subtotals_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Orders_Qry_RequestHandler,Northwind_dbo_Orders_Qry_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Product_Sales_for_1997_RequestHandler,Northwind_dbo_Product_Sales_for_1997_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Products_Above_Average_Price_RequestHandler,Northwind_dbo_Products_Above_Average_Price_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Products_by_Category_RequestHandler,Northwind_dbo_Products_by_Category_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Quarterly_Orders_RequestHandler,Northwind_dbo_Quarterly_Orders_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Sales_by_Category_RequestHandler,Northwind_dbo_Sales_by_Category_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Sales_Totals_by_Amount_RequestHandler,Northwind_dbo_Sales_Totals_by_Amount_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Summary_of_Sales_by_Quarter_RequestHandler,Northwind_dbo_Summary_of_Sales_by_Quarter_RequestHandler>();
		builder.Services.AddScoped<INorthwind_dbo_Summary_of_Sales_by_Year_RequestHandler,Northwind_dbo_Summary_of_Sales_by_Year_RequestHandler>();
		builder.Services.AddScoped<Northwind_dbo_Categories_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_Categories_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_Categories_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_Categories_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_CustomerCustomerDemo_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_CustomerCustomerDemo_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_CustomerCustomerDemo_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_CustomerCustomerDemo_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_CustomerDemographics_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_CustomerDemographics_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_CustomerDemographics_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_CustomerDemographics_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_Customers_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_Customers_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_Customers_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_Customers_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_Employees_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_Employees_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_Employees_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_Employees_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_EmployeeTerritories_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_EmployeeTerritories_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_EmployeeTerritories_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_EmployeeTerritories_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_Order_Details_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_Order_Details_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_Order_Details_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_Order_Details_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_Orders_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_Orders_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_Orders_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_Orders_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_Products_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_Products_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_Products_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_Products_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_Region_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_Region_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_Region_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_Region_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_Shippers_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_Shippers_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_Shippers_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_Shippers_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_Suppliers_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_Suppliers_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_Suppliers_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_Suppliers_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_Territories_IR_FluentValidator_Create>();
		builder.Services.AddScoped<Northwind_dbo_Territories_IR_FluentValidator_Read>();
		builder.Services.AddScoped<Northwind_dbo_Territories_IR_FluentValidator_Update>();
		builder.Services.AddScoped<Northwind_dbo_Territories_IR_FluentValidator_Delete>();
		builder.Services.AddScoped<Northwind_dbo_Alphabetical_list_of_products_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Category_Sales_for_1997_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Current_Product_List_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Customer_and_Suppliers_by_City_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Invoices_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Order_Details_Extended_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Order_Subtotals_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Orders_Qry_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Product_Sales_for_1997_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Products_Above_Average_Price_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Products_by_Category_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Quarterly_Orders_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Sales_by_Category_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Sales_Totals_by_Amount_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Summary_of_Sales_by_Quarter_IR_FluentValidator>();
		builder.Services.AddScoped<Northwind_dbo_Summary_of_Sales_by_Year_IR_FluentValidator>();
        //configure SignalR Websocket services
        // Build the app
        app = builder.Build();
        // Register Hubs
		app.MapHub<Northwind_dbo_Categories_Hub>("Northwind_dbo_Categories_Hub");
		app.MapHub<Northwind_dbo_CustomerCustomerDemo_Hub>("Northwind_dbo_CustomerCustomerDemo_Hub");
		app.MapHub<Northwind_dbo_CustomerDemographics_Hub>("Northwind_dbo_CustomerDemographics_Hub");
		app.MapHub<Northwind_dbo_Customers_Hub>("Northwind_dbo_Customers_Hub");
		app.MapHub<Northwind_dbo_Employees_Hub>("Northwind_dbo_Employees_Hub");
		app.MapHub<Northwind_dbo_EmployeeTerritories_Hub>("Northwind_dbo_EmployeeTerritories_Hub");
		app.MapHub<Northwind_dbo_Order_Details_Hub>("Northwind_dbo_Order_Details_Hub");
		app.MapHub<Northwind_dbo_Orders_Hub>("Northwind_dbo_Orders_Hub");
		app.MapHub<Northwind_dbo_Products_Hub>("Northwind_dbo_Products_Hub");
		app.MapHub<Northwind_dbo_Region_Hub>("Northwind_dbo_Region_Hub");
		app.MapHub<Northwind_dbo_Shippers_Hub>("Northwind_dbo_Shippers_Hub");
		app.MapHub<Northwind_dbo_Suppliers_Hub>("Northwind_dbo_Suppliers_Hub");
		app.MapHub<Northwind_dbo_Territories_Hub>("Northwind_dbo_Territories_Hub");
		app.MapHub<Northwind_dbo_Alphabetical_list_of_products_Hub>("Northwind_dbo_Alphabetical_list_of_products_Hub");
		app.MapHub<Northwind_dbo_Category_Sales_for_1997_Hub>("Northwind_dbo_Category_Sales_for_1997_Hub");
		app.MapHub<Northwind_dbo_Current_Product_List_Hub>("Northwind_dbo_Current_Product_List_Hub");
		app.MapHub<Northwind_dbo_Customer_and_Suppliers_by_City_Hub>("Northwind_dbo_Customer_and_Suppliers_by_City_Hub");
		app.MapHub<Northwind_dbo_Invoices_Hub>("Northwind_dbo_Invoices_Hub");
		app.MapHub<Northwind_dbo_Order_Details_Extended_Hub>("Northwind_dbo_Order_Details_Extended_Hub");
		app.MapHub<Northwind_dbo_Order_Subtotals_Hub>("Northwind_dbo_Order_Subtotals_Hub");
		app.MapHub<Northwind_dbo_Orders_Qry_Hub>("Northwind_dbo_Orders_Qry_Hub");
		app.MapHub<Northwind_dbo_Product_Sales_for_1997_Hub>("Northwind_dbo_Product_Sales_for_1997_Hub");
		app.MapHub<Northwind_dbo_Products_Above_Average_Price_Hub>("Northwind_dbo_Products_Above_Average_Price_Hub");
		app.MapHub<Northwind_dbo_Products_by_Category_Hub>("Northwind_dbo_Products_by_Category_Hub");
		app.MapHub<Northwind_dbo_Quarterly_Orders_Hub>("Northwind_dbo_Quarterly_Orders_Hub");
		app.MapHub<Northwind_dbo_Sales_by_Category_Hub>("Northwind_dbo_Sales_by_Category_Hub");
		app.MapHub<Northwind_dbo_Sales_Totals_by_Amount_Hub>("Northwind_dbo_Sales_Totals_by_Amount_Hub");
		app.MapHub<Northwind_dbo_Summary_of_Sales_by_Quarter_Hub>("Northwind_dbo_Summary_of_Sales_by_Quarter_Hub");
		app.MapHub<Northwind_dbo_Summary_of_Sales_by_Year_Hub>("Northwind_dbo_Summary_of_Sales_by_Year_Hub");
        app.UseCors("AllowSpecificOrigin");
        // Run the app
        app.Run();
    }
}
