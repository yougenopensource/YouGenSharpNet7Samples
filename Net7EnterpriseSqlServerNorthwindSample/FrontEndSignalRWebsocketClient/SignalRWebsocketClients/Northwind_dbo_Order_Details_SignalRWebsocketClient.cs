/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.SignalR.Client;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
public class Northwind_dbo_Order_Details_SignalRWebsocketClient : SignalRWebsocketClientBase, INorthwind_dbo_Order_Details_SignalRWebsocketClient, IAsyncDisposable
{
	public Northwind_dbo_Order_Details_SignalRWebsocketClient(String hubUrl) : base(hubUrl)
    {
    }
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Order_Details_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Order_Details_IR>? retData;
		if (input.OrderID_IR_HasBeenChanged && input.ProductID_IR_HasBeenChanged) retData = await GetByOrderIDAndProductID(input.OrderID_IR ?? default, input.ProductID_IR ?? default);
		else if (input.OrderID_IR_HasBeenChanged) retData = await GetByOrderID(input.OrderID_IR ?? default);
		else if (input.ProductID_IR_HasBeenChanged) retData = await GetByProductID(input.ProductID_IR ?? default);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Order_Details_IR record, Northwind_dbo_Order_Details_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.Discount_HasBeenChanged || record.Discount == filter.Discount);
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetAll()
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Order_Details_IR>?>("GetAll");
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByOrderIDAndProductID(String? orderID_IR, String? productID_IR)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Order_Details_IR>?>("GetByOrderIDAndProductID", orderID_IR, productID_IR);
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByOrderID(String? orderID_IR)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Order_Details_IR>?>("GetByOrderID", orderID_IR);
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByProductID(String? productID_IR)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Order_Details_IR>?>("GetByProductID", productID_IR);
	}
	public async Task<Northwind_dbo_Order_Details_IR?> Create(Northwind_dbo_Order_Details_IR input)
	{
		return await _hubConnection.InvokeAsync<Northwind_dbo_Order_Details_IR?>("Create", input);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_Order_Details_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByOrderIDAndProductID(inputSplits[0], inputSplits[1], updateModel);
	}
	public async Task UpdateByOrderIDAndProductID(String? orderID_IR, String? productID_IR, Northwind_dbo_Order_Details_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByOrderIDAndProductID", orderID_IR, productID_IR, input);
	}
	public async Task UpdateByOrderID(String? orderID_IR, Northwind_dbo_Order_Details_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByOrderID", orderID_IR, input);
	}
	public async Task UpdateByProductID(String? productID_IR, Northwind_dbo_Order_Details_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByProductID", productID_IR, input);
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByOrderIDAndProductID(inputSplits[0], inputSplits[1]);
	}
	public async Task DeleteByOrderIDAndProductID(String? orderID_IR, String? productID_IR)
	{
		await _hubConnection.InvokeAsync("DeleteByOrderIDAndProductID", orderID_IR, productID_IR);
	}
	public async Task DeleteByOrderID(String? orderID_IR)
	{
		await _hubConnection.InvokeAsync("DeleteByOrderID", orderID_IR);
	}
	public async Task DeleteByProductID(String? productID_IR)
	{
		await _hubConnection.InvokeAsync("DeleteByProductID", productID_IR);
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
