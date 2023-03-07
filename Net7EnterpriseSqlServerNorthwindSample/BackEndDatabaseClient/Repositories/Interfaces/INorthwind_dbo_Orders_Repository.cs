/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public interface INorthwind_dbo_Orders_Repository : IGenericTableRepository<Northwind_dbo_Orders>
{
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByCustomerID(String? customerID_);
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByEmployeeID(Int32? employeeID_);
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByOrderDate(DateTime? orderDate_);
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByOrderID(Int32 orderID_);
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByShippedDate(DateTime? shippedDate_);
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByShipVia(Int32? shipVia_);
	Task<IEnumerable<Northwind_dbo_Orders>?> GetByShipPostalCode(String? shipPostalCode_);
	Task UpdateByCustomerID(String? customerID_, Northwind_dbo_Orders entity);
	Task UpdateByEmployeeID(Int32? employeeID_, Northwind_dbo_Orders entity);
	Task UpdateByOrderDate(DateTime? orderDate_, Northwind_dbo_Orders entity);
	Task UpdateByOrderID(Int32 orderID_, Northwind_dbo_Orders entity);
	Task UpdateByShippedDate(DateTime? shippedDate_, Northwind_dbo_Orders entity);
	Task UpdateByShipVia(Int32? shipVia_, Northwind_dbo_Orders entity);
	Task UpdateByShipPostalCode(String? shipPostalCode_, Northwind_dbo_Orders entity);
	Task DeleteByCustomerID(String? customerID_);
	Task DeleteByEmployeeID(Int32? employeeID_);
	Task DeleteByOrderDate(DateTime? orderDate_);
	Task DeleteByOrderID(Int32 orderID_);
	Task DeleteByShippedDate(DateTime? shippedDate_);
	Task DeleteByShipVia(Int32? shipVia_);
	Task DeleteByShipPostalCode(String? shipPostalCode_);
}
