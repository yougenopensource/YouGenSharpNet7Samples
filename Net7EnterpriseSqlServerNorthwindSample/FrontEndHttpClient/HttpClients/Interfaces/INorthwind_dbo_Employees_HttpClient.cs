/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndHttpClient.HttpClients;
public interface INorthwind_dbo_Employees_HttpClient
{
	Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetAll();
	Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Employees_IR input);
	Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetByLastName(String lastName);
	Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetByEmployeeID(String? employeeID_IR);
	Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetByPostalCode(String? postalCode);
	Task<Northwind_dbo_Employees_IR?> Create(Northwind_dbo_Employees_IR input);
	Task UpdateByLastName(String lastName, Northwind_dbo_Employees_IR input);
	Task UpdateByEmployeeID(String? employeeID_IR, Northwind_dbo_Employees_IR input);
	Task UpdateByPostalCode(String? postalCode, Northwind_dbo_Employees_IR input);
	Task DeleteByLastName(String lastName);
	Task DeleteByEmployeeID(String? employeeID_IR);
	Task DeleteByPostalCode(String? postalCode);
}
