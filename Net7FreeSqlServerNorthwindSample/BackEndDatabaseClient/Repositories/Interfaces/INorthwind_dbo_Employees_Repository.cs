/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200257 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public interface INorthwind_dbo_Employees_Repository : IGenericTableRepository<Northwind_dbo_Employees>
{
	Task<IEnumerable<Northwind_dbo_Employees>?> GetByLastName(String lastName_);
	Task<IEnumerable<Northwind_dbo_Employees>?> GetByEmployeeID(Int32 employeeID_);
	Task<IEnumerable<Northwind_dbo_Employees>?> GetByPostalCode(String? postalCode_);
	Task UpdateByLastName(String lastName_, Northwind_dbo_Employees entity);
	Task UpdateByEmployeeID(Int32 employeeID_, Northwind_dbo_Employees entity);
	Task UpdateByPostalCode(String? postalCode_, Northwind_dbo_Employees entity);
	Task DeleteByLastName(String lastName_);
	Task DeleteByEmployeeID(Int32 employeeID_);
	Task DeleteByPostalCode(String? postalCode_);
}
