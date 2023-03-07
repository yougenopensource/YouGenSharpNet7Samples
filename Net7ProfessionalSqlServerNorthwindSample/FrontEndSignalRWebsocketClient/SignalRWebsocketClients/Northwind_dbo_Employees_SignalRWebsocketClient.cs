/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.SignalR.Client;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
public class Northwind_dbo_Employees_SignalRWebsocketClient : SignalRWebsocketClientBase, INorthwind_dbo_Employees_SignalRWebsocketClient, IAsyncDisposable
{
	public Northwind_dbo_Employees_SignalRWebsocketClient(String hubUrl) : base(hubUrl)
    {
    }
	public async Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Employees_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Employees_IR>? retData;
		if (input.LastName_HasBeenChanged) retData = await GetByLastName(input.LastName ?? String.Empty);
		else if (input.EmployeeID_IR_HasBeenChanged) retData = await GetByEmployeeID(input.EmployeeID_IR ?? default);
		else if (input.PostalCode_HasBeenChanged) retData = await GetByPostalCode(input.PostalCode);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Employees_IR record, Northwind_dbo_Employees_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.LastName_HasBeenChanged || record.LastName == filter.LastName) &&
			(!filter.FirstName_HasBeenChanged || record.FirstName == filter.FirstName) &&
			(!filter.Title_HasBeenChanged || record.Title == filter.Title) &&
			(!filter.TitleOfCourtesy_HasBeenChanged || record.TitleOfCourtesy == filter.TitleOfCourtesy) &&
			(!filter.BirthDate_HasBeenChanged || record.BirthDate == filter.BirthDate) &&
			(!filter.HireDate_HasBeenChanged || record.HireDate == filter.HireDate) &&
			(!filter.Address_HasBeenChanged || record.Address == filter.Address) &&
			(!filter.City_HasBeenChanged || record.City == filter.City) &&
			(!filter.Region_HasBeenChanged || record.Region == filter.Region) &&
			(!filter.PostalCode_HasBeenChanged || record.PostalCode == filter.PostalCode) &&
			(!filter.Country_HasBeenChanged || record.Country == filter.Country) &&
			(!filter.HomePhone_HasBeenChanged || record.HomePhone == filter.HomePhone) &&
			(!filter.Extension_HasBeenChanged || record.Extension == filter.Extension) &&
			(!filter.Photo_HasBeenChanged || record.Photo == filter.Photo) &&
			(!filter.Notes_HasBeenChanged || record.Notes == filter.Notes) &&
			(!filter.PhotoPath_HasBeenChanged || record.PhotoPath == filter.PhotoPath);
	}
	public async Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetAll()
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Employees_IR>?>("GetAll");
	}
	public async Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetByLastName(String lastName)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Employees_IR>?>("GetByLastName", lastName);
	}
	public async Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetByEmployeeID(String? employeeID_IR)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Employees_IR>?>("GetByEmployeeID", employeeID_IR);
	}
	public async Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetByPostalCode(String? postalCode)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Employees_IR>?>("GetByPostalCode", postalCode);
	}
	public async Task<Northwind_dbo_Employees_IR?> Create(Northwind_dbo_Employees_IR input)
	{
		return await _hubConnection.InvokeAsync<Northwind_dbo_Employees_IR?>("Create", input);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_Employees_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByEmployeeID(inputSplits[0], updateModel);
	}
	public async Task UpdateByLastName(String lastName, Northwind_dbo_Employees_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByLastName", lastName, input);
	}
	public async Task UpdateByEmployeeID(String? employeeID_IR, Northwind_dbo_Employees_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByEmployeeID", employeeID_IR, input);
	}
	public async Task UpdateByPostalCode(String? postalCode, Northwind_dbo_Employees_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByPostalCode", postalCode, input);
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByEmployeeID(inputSplits[0]);
	}
	public async Task DeleteByLastName(String lastName)
	{
		await _hubConnection.InvokeAsync("DeleteByLastName", lastName);
	}
	public async Task DeleteByEmployeeID(String? employeeID_IR)
	{
		await _hubConnection.InvokeAsync("DeleteByEmployeeID", employeeID_IR);
	}
	public async Task DeleteByPostalCode(String? postalCode)
	{
		await _hubConnection.InvokeAsync("DeleteByPostalCode", postalCode);
	}
    public async Task InitializeAsync()
    {
        await base.EstablishConnection();
    }
    public Boolean GetStatus()
    {
        return base.Initiated;
    }
    public async ValueTask DisposeAsync()
    {
        await base.TerminateConnection();
        GC.SuppressFinalize(this);
    }
}
