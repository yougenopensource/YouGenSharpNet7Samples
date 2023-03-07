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
public class Northwind_dbo_Employee_Sales_by_Country_StoredProcedure_SignalRWebsocketClient : SignalRWebsocketClientBase, INorthwind_dbo_Employee_Sales_by_Country_StoredProcedure_SignalRWebsocketClient, IAsyncDisposable
{
	public Northwind_dbo_Employee_Sales_by_Country_StoredProcedure_SignalRWebsocketClient(String hubUrl) : base(hubUrl)
    {
    }
	public async Task<IEnumerable<Northwind_dbo_Employee_Sales_by_Country_OM_IR>?> Call_Northwind_dbo_Employee_Sales_by_Country(Northwind_dbo_Employee_Sales_by_Country_IM_IR input)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Employee_Sales_by_Country_OM_IR>?>("Call_Northwind_dbo_Employee_Sales_by_Country", input);
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
