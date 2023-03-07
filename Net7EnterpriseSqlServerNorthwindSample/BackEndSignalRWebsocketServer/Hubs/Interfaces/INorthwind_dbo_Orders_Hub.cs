/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndSignalRWebsocketServer.Hubs;
public interface INorthwind_dbo_Orders_Hub
{
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> HandleGeAll();
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByCustomerID(String? customerID);
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByEmployeeID(String? employeeID_IR);
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByOrderDate(DateTime? orderDate);
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByOrderID(String? orderID_IR);
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByShippedDate(DateTime? shippedDate);
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByShipVia(String? shipVia_IR);
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> GetByShipPostalCode(String? shipPostalCode);
	Task<Northwind_dbo_Orders_IR?> HandleCreate(Northwind_dbo_Orders_IR input);
	Task UpdateByCustomerID(String? customerID, Northwind_dbo_Orders_IR input);
	Task UpdateByEmployeeID(String? employeeID_IR, Northwind_dbo_Orders_IR input);
	Task UpdateByOrderDate(DateTime? orderDate, Northwind_dbo_Orders_IR input);
	Task UpdateByOrderID(String? orderID_IR, Northwind_dbo_Orders_IR input);
	Task UpdateByShippedDate(DateTime? shippedDate, Northwind_dbo_Orders_IR input);
	Task UpdateByShipVia(String? shipVia_IR, Northwind_dbo_Orders_IR input);
	Task UpdateByShipPostalCode(String? shipPostalCode, Northwind_dbo_Orders_IR input);
	Task DeleteByCustomerID(String? customerID);
	Task DeleteByEmployeeID(String? employeeID_IR);
	Task DeleteByOrderDate(DateTime? orderDate);
	Task DeleteByOrderID(String? orderID_IR);
	Task DeleteByShippedDate(DateTime? shippedDate);
	Task DeleteByShipVia(String? shipVia_IR);
	Task DeleteByShipPostalCode(String? shipPostalCode);
}
