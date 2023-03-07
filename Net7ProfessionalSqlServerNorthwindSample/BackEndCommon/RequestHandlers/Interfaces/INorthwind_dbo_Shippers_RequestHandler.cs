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
public interface INorthwind_dbo_Shippers_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<Northwind_dbo_Shippers_IR>?> HandleGetAll();
	Task<IEnumerable<Northwind_dbo_Shippers_IR>?> HandleGetByShipperID(String? shipperID_IR);
	Task<Northwind_dbo_Shippers_IR?> HandleCreate<T>(T irModel) where T : Northwind_dbo_Shippers_IR;
	Task HandleUpdateByShipperID<T>(String? shipperID_IR, T irModel) where T: Northwind_dbo_Shippers_IR;
	Task HandleDeleteByShipperID(String? shipperID_IR);
}
