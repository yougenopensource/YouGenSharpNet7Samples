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
public class Northwind_dbo_Products_SignalRWebsocketClient : SignalRWebsocketClientBase, INorthwind_dbo_Products_SignalRWebsocketClient, IAsyncDisposable
{
	public Northwind_dbo_Products_SignalRWebsocketClient(String hubUrl) : base(hubUrl)
    {
    }
	public async Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Products_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Products_IR>? retData;
		if (input.CategoryID_IR_HasBeenChanged) retData = await GetByCategoryID(input.CategoryID_IR);
		else if (input.ProductID_IR_HasBeenChanged) retData = await GetByProductID(input.ProductID_IR ?? default);
		else if (input.ProductName_HasBeenChanged) retData = await GetByProductName(input.ProductName ?? String.Empty);
		else if (input.SupplierID_IR_HasBeenChanged) retData = await GetBySupplierID(input.SupplierID_IR);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Products_IR record, Northwind_dbo_Products_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.ProductName_HasBeenChanged || record.ProductName == filter.ProductName) &&
			(!filter.QuantityPerUnit_HasBeenChanged || record.QuantityPerUnit == filter.QuantityPerUnit) &&
			(!filter.Discontinued_HasBeenChanged || record.Discontinued == filter.Discontinued);
	}
	public async Task<IEnumerable<Northwind_dbo_Products_IR>?> GetAll()
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Products_IR>?>("GetAll");
	}
	public async Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByCategoryID(String? categoryID_IR)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Products_IR>?>("GetByCategoryID", categoryID_IR);
	}
	public async Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByProductID(String? productID_IR)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Products_IR>?>("GetByProductID", productID_IR);
	}
	public async Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByProductName(String productName)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Products_IR>?>("GetByProductName", productName);
	}
	public async Task<IEnumerable<Northwind_dbo_Products_IR>?> GetBySupplierID(String? supplierID_IR)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Products_IR>?>("GetBySupplierID", supplierID_IR);
	}
	public async Task<Northwind_dbo_Products_IR?> Create(Northwind_dbo_Products_IR input)
	{
		return await _hubConnection.InvokeAsync<Northwind_dbo_Products_IR?>("Create", input);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_Products_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByProductID(inputSplits[0], updateModel);
	}
	public async Task UpdateByCategoryID(String? categoryID_IR, Northwind_dbo_Products_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByCategoryID", categoryID_IR, input);
	}
	public async Task UpdateByProductID(String? productID_IR, Northwind_dbo_Products_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByProductID", productID_IR, input);
	}
	public async Task UpdateByProductName(String productName, Northwind_dbo_Products_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByProductName", productName, input);
	}
	public async Task UpdateBySupplierID(String? supplierID_IR, Northwind_dbo_Products_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateBySupplierID", supplierID_IR, input);
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByProductID(inputSplits[0]);
	}
	public async Task DeleteByCategoryID(String? categoryID_IR)
	{
		await _hubConnection.InvokeAsync("DeleteByCategoryID", categoryID_IR);
	}
	public async Task DeleteByProductID(String? productID_IR)
	{
		await _hubConnection.InvokeAsync("DeleteByProductID", productID_IR);
	}
	public async Task DeleteByProductName(String productName)
	{
		await _hubConnection.InvokeAsync("DeleteByProductName", productName);
	}
	public async Task DeleteBySupplierID(String? supplierID_IR)
	{
		await _hubConnection.InvokeAsync("DeleteBySupplierID", supplierID_IR);
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
