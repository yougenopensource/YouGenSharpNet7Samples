/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200434 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndCommon.RequestHandlers;
public interface INorthwind_dbo_Categories_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<Northwind_dbo_Categories>?> HandleGetAll();
	Task<IEnumerable<Northwind_dbo_Categories>?> HandleGetByCategoryName(String categoryName);
	Task<IEnumerable<Northwind_dbo_Categories>?> HandleGetByCategoryID(Int32 categoryID);
	Task<Northwind_dbo_Categories?> HandleCreate(Northwind_dbo_Categories entity);
	Task HandleUpdateByCategoryName(String categoryName, Northwind_dbo_Categories entity);
	Task HandleUpdateByCategoryID(Int32 categoryID, Northwind_dbo_Categories entity);
	Task HandleDeleteByCategoryName(String categoryName);
	Task HandleDeleteByCategoryID(Int32 categoryID);
}
