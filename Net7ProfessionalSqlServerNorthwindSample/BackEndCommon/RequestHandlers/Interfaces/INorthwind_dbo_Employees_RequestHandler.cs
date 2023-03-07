/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCommon.RequestHandlers;
public interface INorthwind_dbo_Employees_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<Northwind_dbo_Employees_IR>?> HandleGetAll();
	Task<IEnumerable<Northwind_dbo_Employees_IR>?> HandleGetByLastName(String lastName);
	Task<IEnumerable<Northwind_dbo_Employees_IR>?> HandleGetByEmployeeID(String? employeeID_IR);
	Task<IEnumerable<Northwind_dbo_Employees_IR>?> HandleGetByPostalCode(String? postalCode);
	Task<Northwind_dbo_Employees_IR?> HandleCreate<T>(T irModel) where T : Northwind_dbo_Employees_IR;
	Task HandleUpdateByLastName<T>(String lastName, T irModel) where T: Northwind_dbo_Employees_IR;
	Task HandleUpdateByEmployeeID<T>(String? employeeID_IR, T irModel) where T: Northwind_dbo_Employees_IR;
	Task HandleUpdateByPostalCode<T>(String? postalCode, T irModel) where T: Northwind_dbo_Employees_IR;
	Task HandleDeleteByLastName(String lastName);
	Task HandleDeleteByEmployeeID(String? employeeID_IR);
	Task HandleDeleteByPostalCode(String? postalCode);
}
