/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200257 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_FrontEndHttpClient.HttpClients;
public class Northwind_dbo_Orders_HttpClient : HttpClientBase, INorthwind_dbo_Orders_HttpClient
{
	public Northwind_dbo_Orders_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Orders/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Orders>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByCustomerID(String? customerID)
	{
		var uri = GetUriForParamsCustomerID("Northwind_dbo_Orders/GetByCustomerID", customerID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Orders>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByEmployeeID(Int32? employeeID)
	{
		var uri = GetUriForParamsEmployeeID("Northwind_dbo_Orders/GetByEmployeeID", employeeID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Orders>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByOrderDate(DateTime? orderDate)
	{
		var uri = GetUriForParamsOrderDate("Northwind_dbo_Orders/GetByOrderDate", orderDate);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Orders>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByOrderID(Int32 orderID)
	{
		var uri = GetUriForParamsOrderID("Northwind_dbo_Orders/GetByOrderID", orderID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Orders>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByShippedDate(DateTime? shippedDate)
	{
		var uri = GetUriForParamsShippedDate("Northwind_dbo_Orders/GetByShippedDate", shippedDate);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Orders>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByShipVia(Int32? shipVia)
	{
		var uri = GetUriForParamsShipVia("Northwind_dbo_Orders/GetByShipVia", shipVia);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Orders>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByShipPostalCode(String? shipPostalCode)
	{
		var uri = GetUriForParamsShipPostalCode("Northwind_dbo_Orders/GetByShipPostalCode", shipPostalCode);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Orders>?>(content, _jsonSerializationSettings);
	}
	public async Task<Northwind_dbo_Orders?> Create(Northwind_dbo_Orders input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Orders/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<Northwind_dbo_Orders?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_Orders updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByOrderID(Convert.ToInt32(inputSplits[0]), updateModel);
	}
	public async Task UpdateByCustomerID(String? customerID, Northwind_dbo_Orders input)
	{
		var uri = GetUriForParamsCustomerID("Northwind_dbo_Orders/UpdateByCustomerID", customerID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByEmployeeID(Int32? employeeID, Northwind_dbo_Orders input)
	{
		var uri = GetUriForParamsEmployeeID("Northwind_dbo_Orders/UpdateByEmployeeID", employeeID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByOrderDate(DateTime? orderDate, Northwind_dbo_Orders input)
	{
		var uri = GetUriForParamsOrderDate("Northwind_dbo_Orders/UpdateByOrderDate", orderDate);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByOrderID(Int32 orderID, Northwind_dbo_Orders input)
	{
		var uri = GetUriForParamsOrderID("Northwind_dbo_Orders/UpdateByOrderID", orderID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByShippedDate(DateTime? shippedDate, Northwind_dbo_Orders input)
	{
		var uri = GetUriForParamsShippedDate("Northwind_dbo_Orders/UpdateByShippedDate", shippedDate);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByShipVia(Int32? shipVia, Northwind_dbo_Orders input)
	{
		var uri = GetUriForParamsShipVia("Northwind_dbo_Orders/UpdateByShipVia", shipVia);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByShipPostalCode(String? shipPostalCode, Northwind_dbo_Orders input)
	{
		var uri = GetUriForParamsShipPostalCode("Northwind_dbo_Orders/UpdateByShipPostalCode", shipPostalCode);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByOrderID(Convert.ToInt32(inputSplits[0]));
	}
	public async Task DeleteByCustomerID(String? customerID)
	{
		var uri = GetUriForParamsCustomerID("Northwind_dbo_Orders/DeleteByCustomerID", customerID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEmployeeID(Int32? employeeID)
	{
		var uri = GetUriForParamsEmployeeID("Northwind_dbo_Orders/DeleteByEmployeeID", employeeID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByOrderDate(DateTime? orderDate)
	{
		var uri = GetUriForParamsOrderDate("Northwind_dbo_Orders/DeleteByOrderDate", orderDate);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByOrderID(Int32 orderID)
	{
		var uri = GetUriForParamsOrderID("Northwind_dbo_Orders/DeleteByOrderID", orderID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByShippedDate(DateTime? shippedDate)
	{
		var uri = GetUriForParamsShippedDate("Northwind_dbo_Orders/DeleteByShippedDate", shippedDate);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByShipVia(Int32? shipVia)
	{
		var uri = GetUriForParamsShipVia("Northwind_dbo_Orders/DeleteByShipVia", shipVia);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByShipPostalCode(String? shipPostalCode)
	{
		var uri = GetUriForParamsShipPostalCode("Northwind_dbo_Orders/DeleteByShipPostalCode", shipPostalCode);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsCustomerID(String path, String? customerID)
	{
		var query = new Dictionary<String,String>();
		query["customerID"] = customerID ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsEmployeeID(String path, Int32? employeeID)
	{
		var query = new Dictionary<String,String>();
		query["employeeID"] = employeeID.ToString() ?? 0.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsOrderDate(String path, DateTime? orderDate)
	{
		var query = new Dictionary<String,String>();
		query["orderDate"] = orderDate.ToString() ?? new DateTime().ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsOrderID(String path, Int32 orderID)
	{
		var query = new Dictionary<String,String>();
		query["orderID"] = orderID.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsShippedDate(String path, DateTime? shippedDate)
	{
		var query = new Dictionary<String,String>();
		query["shippedDate"] = shippedDate.ToString() ?? new DateTime().ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsShipVia(String path, Int32? shipVia)
	{
		var query = new Dictionary<String,String>();
		query["shipVia"] = shipVia.ToString() ?? 0.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsShipPostalCode(String path, String? shipPostalCode)
	{
		var query = new Dictionary<String,String>();
		query["shipPostalCode"] = shipPostalCode ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
