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
public interface INorthwind_dbo_Products_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<Northwind_dbo_Products_IR>?> HandleGetAll();
	Task<IEnumerable<Northwind_dbo_Products_IR>?> HandleGetByCategoryID(String? categoryID_IR);
	Task<IEnumerable<Northwind_dbo_Products_IR>?> HandleGetByProductID(String? productID_IR);
	Task<IEnumerable<Northwind_dbo_Products_IR>?> HandleGetByProductName(String productName);
	Task<IEnumerable<Northwind_dbo_Products_IR>?> HandleGetBySupplierID(String? supplierID_IR);
	Task<Northwind_dbo_Products_IR?> HandleCreate<T>(T irModel) where T : Northwind_dbo_Products_IR;
	Task HandleUpdateByCategoryID<T>(String? categoryID_IR, T irModel) where T: Northwind_dbo_Products_IR;
	Task HandleUpdateByProductID<T>(String? productID_IR, T irModel) where T: Northwind_dbo_Products_IR;
	Task HandleUpdateByProductName<T>(String productName, T irModel) where T: Northwind_dbo_Products_IR;
	Task HandleUpdateBySupplierID<T>(String? supplierID_IR, T irModel) where T: Northwind_dbo_Products_IR;
	Task HandleDeleteByCategoryID(String? categoryID_IR);
	Task HandleDeleteByProductID(String? productID_IR);
	Task HandleDeleteByProductName(String productName);
	Task HandleDeleteBySupplierID(String? supplierID_IR);
}
