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
public interface INorthwind_dbo_Quarterly_Orders_HttpClient
{
	Task<IEnumerable<Northwind_dbo_Quarterly_Orders_IR>?> GetAll();
	Task<IEnumerable<Northwind_dbo_Quarterly_Orders_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Quarterly_Orders_IR input);
}
