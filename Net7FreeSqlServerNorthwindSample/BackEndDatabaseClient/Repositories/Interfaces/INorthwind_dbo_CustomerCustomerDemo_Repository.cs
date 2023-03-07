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
public interface INorthwind_dbo_CustomerCustomerDemo_Repository : IGenericTableRepository<Northwind_dbo_CustomerCustomerDemo>
{
	Task<IEnumerable<Northwind_dbo_CustomerCustomerDemo>?> GetByCustomerIDAndCustomerTypeID(String customerID_, String customerTypeID_);
	Task UpdateByCustomerIDAndCustomerTypeID(String customerID_, String customerTypeID_, Northwind_dbo_CustomerCustomerDemo entity);
	Task DeleteByCustomerIDAndCustomerTypeID(String customerID_, String customerTypeID_);
}
