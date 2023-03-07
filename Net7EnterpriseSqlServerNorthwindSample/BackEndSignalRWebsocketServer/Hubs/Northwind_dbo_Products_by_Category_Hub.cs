/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.SignalR;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndSignalRWebsocketServer.Hubs;
public class Northwind_dbo_Products_by_Category_Hub : Hub<INorthwind_dbo_Products_by_Category_Hub>
{
	private readonly INorthwind_dbo_Products_by_Category_RequestHandler _requestHandler;
	public Northwind_dbo_Products_by_Category_Hub(INorthwind_dbo_Products_by_Category_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<IEnumerable<Northwind_dbo_Products_by_Category_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
}
