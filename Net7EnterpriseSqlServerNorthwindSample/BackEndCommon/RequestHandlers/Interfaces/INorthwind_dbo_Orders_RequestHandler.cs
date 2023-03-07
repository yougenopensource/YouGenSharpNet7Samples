/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCommon.RequestHandlers;
public interface INorthwind_dbo_Orders_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> HandleGetAll();
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> HandleGetByCustomerID(String? customerID);
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> HandleGetByEmployeeID(String? employeeID_IR);
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> HandleGetByOrderDate(DateTime? orderDate);
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> HandleGetByOrderID(String? orderID_IR);
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> HandleGetByShippedDate(DateTime? shippedDate);
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> HandleGetByShipVia(String? shipVia_IR);
	Task<IEnumerable<Northwind_dbo_Orders_IR>?> HandleGetByShipPostalCode(String? shipPostalCode);
	Task<Northwind_dbo_Orders_IR?> HandleCreate<T>(T irModel) where T : Northwind_dbo_Orders_IR;
	Task HandleUpdateByCustomerID<T>(String? customerID, T irModel) where T: Northwind_dbo_Orders_IR;
	Task HandleUpdateByEmployeeID<T>(String? employeeID_IR, T irModel) where T: Northwind_dbo_Orders_IR;
	Task HandleUpdateByOrderDate<T>(DateTime? orderDate, T irModel) where T: Northwind_dbo_Orders_IR;
	Task HandleUpdateByOrderID<T>(String? orderID_IR, T irModel) where T: Northwind_dbo_Orders_IR;
	Task HandleUpdateByShippedDate<T>(DateTime? shippedDate, T irModel) where T: Northwind_dbo_Orders_IR;
	Task HandleUpdateByShipVia<T>(String? shipVia_IR, T irModel) where T: Northwind_dbo_Orders_IR;
	Task HandleUpdateByShipPostalCode<T>(String? shipPostalCode, T irModel) where T: Northwind_dbo_Orders_IR;
	Task HandleDeleteByCustomerID(String? customerID);
	Task HandleDeleteByEmployeeID(String? employeeID_IR);
	Task HandleDeleteByOrderDate(DateTime? orderDate);
	Task HandleDeleteByOrderID(String? orderID_IR);
	Task HandleDeleteByShippedDate(DateTime? shippedDate);
	Task HandleDeleteByShipVia(String? shipVia_IR);
	Task HandleDeleteByShipPostalCode(String? shipPostalCode);
}
