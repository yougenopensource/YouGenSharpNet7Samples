/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
public interface INorthwind_dbo_Products_SignalRWebsocketClient
{
	Task<IEnumerable<Northwind_dbo_Products_IR>?> GetAll();
	Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Products_IR input);
	Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByCategoryID(String? categoryID_IR);
	Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByProductID(String? productID_IR);
	Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByProductName(String productName);
	Task<IEnumerable<Northwind_dbo_Products_IR>?> GetBySupplierID(String? supplierID_IR);
	Task<Northwind_dbo_Products_IR?> Create(Northwind_dbo_Products_IR input);
	Task UpdateByCategoryID(String? categoryID_IR, Northwind_dbo_Products_IR input);
	Task UpdateByProductID(String? productID_IR, Northwind_dbo_Products_IR input);
	Task UpdateByProductName(String productName, Northwind_dbo_Products_IR input);
	Task UpdateBySupplierID(String? supplierID_IR, Northwind_dbo_Products_IR input);
	Task DeleteByCategoryID(String? categoryID_IR);
	Task DeleteByProductID(String? productID_IR);
	Task DeleteByProductName(String productName);
	Task DeleteBySupplierID(String? supplierID_IR);
    Task InitializeAsync();
    Boolean GetStatus();
    ValueTask DisposeAsync();
}
