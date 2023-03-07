/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
public interface INorthwind_dbo_Order_Details_SignalRWebsocketClient
{
	Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetAll();
	Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Order_Details_IR input);
	Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByOrderIDAndProductID(String? orderID_IR, String? productID_IR);
	Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByOrderID(String? orderID_IR);
	Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByProductID(String? productID_IR);
	Task<Northwind_dbo_Order_Details_IR?> Create(Northwind_dbo_Order_Details_IR input);
	Task UpdateByOrderIDAndProductID(String? orderID_IR, String? productID_IR, Northwind_dbo_Order_Details_IR input);
	Task UpdateByOrderID(String? orderID_IR, Northwind_dbo_Order_Details_IR input);
	Task UpdateByProductID(String? productID_IR, Northwind_dbo_Order_Details_IR input);
	Task DeleteByOrderIDAndProductID(String? orderID_IR, String? productID_IR);
	Task DeleteByOrderID(String? orderID_IR);
	Task DeleteByProductID(String? productID_IR);
    Task InitializeAsync();
    Boolean GetStatus();
    ValueTask DisposeAsync();
}
