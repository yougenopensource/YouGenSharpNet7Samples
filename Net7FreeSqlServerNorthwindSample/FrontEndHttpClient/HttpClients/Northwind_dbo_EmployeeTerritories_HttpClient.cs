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
public class Northwind_dbo_EmployeeTerritories_HttpClient : HttpClientBase, INorthwind_dbo_EmployeeTerritories_HttpClient
{
	public Northwind_dbo_EmployeeTerritories_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_EmployeeTerritories>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_EmployeeTerritories/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_EmployeeTerritories>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_EmployeeTerritories>?> GetByEmployeeIDAndTerritoryID(Int32 employeeID, String territoryID)
	{
		var uri = GetUriForParamsEmployeeIDAndTerritoryID("Northwind_dbo_EmployeeTerritories/GetByEmployeeIDAndTerritoryID", employeeID, territoryID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_EmployeeTerritories>?>(content, _jsonSerializationSettings);
	}
	public async Task<Northwind_dbo_EmployeeTerritories?> Create(Northwind_dbo_EmployeeTerritories input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_EmployeeTerritories/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<Northwind_dbo_EmployeeTerritories?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_EmployeeTerritories updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByEmployeeIDAndTerritoryID(Convert.ToInt32(inputSplits[0]), (inputSplits[1]), updateModel);
	}
	public async Task UpdateByEmployeeIDAndTerritoryID(Int32 employeeID, String territoryID, Northwind_dbo_EmployeeTerritories input)
	{
		var uri = GetUriForParamsEmployeeIDAndTerritoryID("Northwind_dbo_EmployeeTerritories/UpdateByEmployeeIDAndTerritoryID", employeeID, territoryID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByEmployeeIDAndTerritoryID(Convert.ToInt32(inputSplits[0]), (inputSplits[1]));
	}
	public async Task DeleteByEmployeeIDAndTerritoryID(Int32 employeeID, String territoryID)
	{
		var uri = GetUriForParamsEmployeeIDAndTerritoryID("Northwind_dbo_EmployeeTerritories/DeleteByEmployeeIDAndTerritoryID", employeeID, territoryID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsEmployeeIDAndTerritoryID(String path, Int32 employeeID, String territoryID)
	{
		var query = new Dictionary<String,String>();
		query["employeeID"] = employeeID.ToString();
		query["territoryID"] = territoryID;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
