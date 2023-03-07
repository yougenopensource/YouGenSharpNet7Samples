/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200434 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public interface INorthwind_dbo_Territories_Repository : IGenericTableRepository<Northwind_dbo_Territories>
{
	Task<IEnumerable<Northwind_dbo_Territories>?> GetByTerritoryID(String territoryID_);
	Task UpdateByTerritoryID(String territoryID_, Northwind_dbo_Territories entity);
	Task DeleteByTerritoryID(String territoryID_);
}
