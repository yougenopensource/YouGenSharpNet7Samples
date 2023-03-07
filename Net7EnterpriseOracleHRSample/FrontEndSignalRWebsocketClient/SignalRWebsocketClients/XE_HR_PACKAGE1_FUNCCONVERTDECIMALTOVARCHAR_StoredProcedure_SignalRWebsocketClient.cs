/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.SignalR.Client;
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
public class XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_StoredProcedure_SignalRWebsocketClient : SignalRWebsocketClientBase, IXE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_StoredProcedure_SignalRWebsocketClient, IAsyncDisposable
{
	public XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_StoredProcedure_SignalRWebsocketClient(String hubUrl) : base(hubUrl)
    {
    }
	public async Task<XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_OM_IR?> Call_XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR(XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_IM_IR input)
	{
		return await _hubConnection.InvokeAsync<XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_OM_IR?>("Call_XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR", input);
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
