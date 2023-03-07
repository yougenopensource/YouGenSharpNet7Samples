/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndHttpClient.HttpClients;
public class Northwind_dbo_Orders_Qry_HttpClient : HttpClientBase, INorthwind_dbo_Orders_Qry_HttpClient
{
	public Northwind_dbo_Orders_Qry_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_Orders_Qry_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Orders_Qry_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Orders_Qry_IR>? retData;
		retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Orders_Qry_IR record, Northwind_dbo_Orders_Qry_IR filter)
	{
		return			(!filter.OrderID_IR_HasBeenChanged || record.OrderID_IR == filter.OrderID_IR) &&
			(!filter.CustomerID_HasBeenChanged || record.CustomerID == filter.CustomerID) &&
			(!filter.EmployeeID_IR_HasBeenChanged || record.EmployeeID_IR == filter.EmployeeID_IR) &&
			(!filter.OrderDate_HasBeenChanged || record.OrderDate == filter.OrderDate) &&
			(!filter.RequiredDate_HasBeenChanged || record.RequiredDate == filter.RequiredDate) &&
			(!filter.ShippedDate_HasBeenChanged || record.ShippedDate == filter.ShippedDate) &&
			(!filter.ShipVia_HasBeenChanged || record.ShipVia == filter.ShipVia) &&
			(!filter.Freight_HasBeenChanged || record.Freight == filter.Freight) &&
			(!filter.ShipName_HasBeenChanged || record.ShipName == filter.ShipName) &&
			(!filter.ShipAddress_HasBeenChanged || record.ShipAddress == filter.ShipAddress) &&
			(!filter.ShipCity_HasBeenChanged || record.ShipCity == filter.ShipCity) &&
			(!filter.ShipRegion_HasBeenChanged || record.ShipRegion == filter.ShipRegion) &&
			(!filter.ShipPostalCode_HasBeenChanged || record.ShipPostalCode == filter.ShipPostalCode) &&
			(!filter.ShipCountry_HasBeenChanged || record.ShipCountry == filter.ShipCountry) &&
			(!filter.CompanyName_HasBeenChanged || record.CompanyName == filter.CompanyName) &&
			(!filter.Address_HasBeenChanged || record.Address == filter.Address) &&
			(!filter.City_HasBeenChanged || record.City == filter.City) &&
			(!filter.Region_HasBeenChanged || record.Region == filter.Region) &&
			(!filter.PostalCode_HasBeenChanged || record.PostalCode == filter.PostalCode) &&
			(!filter.Country_HasBeenChanged || record.Country == filter.Country);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders_Qry_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Orders_Qry/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Orders_Qry_IR>?>(content, _jsonSerializationSettings);
	}
}
