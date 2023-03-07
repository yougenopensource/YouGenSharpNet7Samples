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
public class Northwind_dbo_CustomerDemographics_SignalRWebsocketClient : SignalRWebsocketClientBase, INorthwind_dbo_CustomerDemographics_SignalRWebsocketClient, IAsyncDisposable
{
	public Northwind_dbo_CustomerDemographics_SignalRWebsocketClient(String hubUrl) : base(hubUrl)
    {
    }
	public async Task<IEnumerable<Northwind_dbo_CustomerDemographics_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_CustomerDemographics_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_CustomerDemographics_IR>? retData;
		if (input.CustomerTypeID_HasBeenChanged) retData = await GetByCustomerTypeID(input.CustomerTypeID ?? String.Empty);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_CustomerDemographics_IR record, Northwind_dbo_CustomerDemographics_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.CustomerDesc_HasBeenChanged || record.CustomerDesc == filter.CustomerDesc);
	}
	public async Task<IEnumerable<Northwind_dbo_CustomerDemographics_IR>?> GetAll()
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_CustomerDemographics_IR>?>("GetAll");
	}
	public async Task<IEnumerable<Northwind_dbo_CustomerDemographics_IR>?> GetByCustomerTypeID(String customerTypeID)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_CustomerDemographics_IR>?>("GetByCustomerTypeID", customerTypeID);
	}
	public async Task<Northwind_dbo_CustomerDemographics_IR?> Create(Northwind_dbo_CustomerDemographics_IR input)
	{
		return await _hubConnection.InvokeAsync<Northwind_dbo_CustomerDemographics_IR?>("Create", input);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_CustomerDemographics_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByCustomerTypeID(inputSplits[0], updateModel);
	}
	public async Task UpdateByCustomerTypeID(String customerTypeID, Northwind_dbo_CustomerDemographics_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByCustomerTypeID", customerTypeID, input);
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByCustomerTypeID(inputSplits[0]);
	}
	public async Task DeleteByCustomerTypeID(String customerTypeID)
	{
		await _hubConnection.InvokeAsync("DeleteByCustomerTypeID", customerTypeID);
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
