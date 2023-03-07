/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Logging;
using XE_HR_FrontEndMudBlazorWebassembly;
using XE_HR_FrontEndMudBlazorWebassembly.Services;
using XE_HR_FrontEndHttpClient.HttpClients;
using XE_HR_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
using XE_HR_Common.Validators;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using MudBlazor.Services;
namespace XE_HR_FrontEndMauiClient;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});
		builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
        // Http client properties
        var httpClientBaseAddress = new Uri("https://localhost:58924");
        var acceptHeaderName = "Accept";
        var acceptHeaderValue = "application/json";
        // Websocket client
        var websocketBaseAddress = "https://localhost:52114";        
        // Register Services
        builder.Services.AddMudServices();
        builder.Services.AddSingleton(new NavigationStateSingleton());
		// Http clients
		// Tables
		builder.Services.AddHttpClient<XE_HR_COUNTRIES_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
		builder.Services.AddHttpClient<XE_HR_DEPARTMENTS_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
		builder.Services.AddHttpClient<XE_HR_EMPLOYEES_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
		builder.Services.AddHttpClient<XE_HR_JOB_HISTORY_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
		builder.Services.AddHttpClient<XE_HR_JOBS_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
		builder.Services.AddHttpClient<XE_HR_LOCATIONS_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
		builder.Services.AddHttpClient<XE_HR_REGIONS_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
		// Views
		builder.Services.AddHttpClient<XE_HR_EMP_DETAILS_VIEW_HttpClient>(c => { c.BaseAddress = httpClientBaseAddress; c.DefaultRequestHeaders.Add(acceptHeaderName, acceptHeaderValue); });
		// Websocket clients
		// Tables
		builder.Services.AddSingleton(new XE_HR_COUNTRIES_SignalRWebsocketClient(websocketBaseAddress + "/XE_HR_COUNTRIES_Hub"));
		builder.Services.AddScoped<XE_HR_COUNTRIES_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_COUNTRIES_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_COUNTRIES_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_COUNTRIES_IR_FluentValidator_Delete>();
		builder.Services.AddSingleton(new XE_HR_DEPARTMENTS_SignalRWebsocketClient(websocketBaseAddress + "/XE_HR_DEPARTMENTS_Hub"));
		builder.Services.AddScoped<XE_HR_DEPARTMENTS_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_DEPARTMENTS_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_DEPARTMENTS_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_DEPARTMENTS_IR_FluentValidator_Delete>();
		builder.Services.AddSingleton(new XE_HR_EMPLOYEES_SignalRWebsocketClient(websocketBaseAddress + "/XE_HR_EMPLOYEES_Hub"));
		builder.Services.AddScoped<XE_HR_EMPLOYEES_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_EMPLOYEES_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_EMPLOYEES_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_EMPLOYEES_IR_FluentValidator_Delete>();
		builder.Services.AddSingleton(new XE_HR_JOB_HISTORY_SignalRWebsocketClient(websocketBaseAddress + "/XE_HR_JOB_HISTORY_Hub"));
		builder.Services.AddScoped<XE_HR_JOB_HISTORY_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_JOB_HISTORY_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_JOB_HISTORY_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_JOB_HISTORY_IR_FluentValidator_Delete>();
		builder.Services.AddSingleton(new XE_HR_JOBS_SignalRWebsocketClient(websocketBaseAddress + "/XE_HR_JOBS_Hub"));
		builder.Services.AddScoped<XE_HR_JOBS_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_JOBS_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_JOBS_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_JOBS_IR_FluentValidator_Delete>();
		builder.Services.AddSingleton(new XE_HR_LOCATIONS_SignalRWebsocketClient(websocketBaseAddress + "/XE_HR_LOCATIONS_Hub"));
		builder.Services.AddScoped<XE_HR_LOCATIONS_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_LOCATIONS_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_LOCATIONS_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_LOCATIONS_IR_FluentValidator_Delete>();
		builder.Services.AddSingleton(new XE_HR_REGIONS_SignalRWebsocketClient(websocketBaseAddress + "/XE_HR_REGIONS_Hub"));
		builder.Services.AddScoped<XE_HR_REGIONS_IR_FluentValidator_Create>();
		builder.Services.AddScoped<XE_HR_REGIONS_IR_FluentValidator_Read>();
		builder.Services.AddScoped<XE_HR_REGIONS_IR_FluentValidator_Update>();
		builder.Services.AddScoped<XE_HR_REGIONS_IR_FluentValidator_Delete>();
		// Views
		builder.Services.AddSingleton(new XE_HR_EMP_DETAILS_VIEW_SignalRWebsocketClient(websocketBaseAddress + "/XE_HR_EMP_DETAILS_VIEW_Hub"));
		builder.Services.AddScoped<XE_HR_EMP_DETAILS_VIEW_IR_FluentValidator>();
		return builder.Build();
	}
}
