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
public class Northwind_dbo_EmployeeTerritories_HttpClient : HttpClientBase, INorthwind_dbo_EmployeeTerritories_HttpClient
{
	public Northwind_dbo_EmployeeTerritories_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_EmployeeTerritories_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_EmployeeTerritories_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_EmployeeTerritories_IR>? retData;
		if (input.EmployeeID_IR_HasBeenChanged && input.TerritoryID_HasBeenChanged) retData = await GetByEmployeeIDAndTerritoryID(input.EmployeeID_IR ?? default, input.TerritoryID ?? String.Empty);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_EmployeeTerritories_IR record, Northwind_dbo_EmployeeTerritories_IR filter)
	{
		 // unencrypted properties only
		return true;	}
	public async Task<IEnumerable<Northwind_dbo_EmployeeTerritories_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_EmployeeTerritories/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_EmployeeTerritories_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_EmployeeTerritories_IR>?> GetByEmployeeIDAndTerritoryID(String? employeeID_IR, String territoryID)
	{
		var uri = GetUriForParamsEmployeeIDAndTerritoryID("Northwind_dbo_EmployeeTerritories/GetByEmployeeIDAndTerritoryID", employeeID_IR, territoryID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_EmployeeTerritories_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<Northwind_dbo_EmployeeTerritories_IR?> Create(Northwind_dbo_EmployeeTerritories_IR input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_EmployeeTerritories/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<Northwind_dbo_EmployeeTerritories_IR?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_EmployeeTerritories_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByEmployeeIDAndTerritoryID(inputSplits[0], inputSplits[1], updateModel);
	}
	public async Task UpdateByEmployeeIDAndTerritoryID(String? employeeID_IR, String territoryID, Northwind_dbo_EmployeeTerritories_IR input)
	{
		var uri = GetUriForParamsEmployeeIDAndTerritoryID("Northwind_dbo_EmployeeTerritories/UpdateByEmployeeIDAndTerritoryID", employeeID_IR, territoryID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByEmployeeIDAndTerritoryID(inputSplits[0], inputSplits[1]);
	}
	public async Task DeleteByEmployeeIDAndTerritoryID(String? employeeID_IR, String territoryID)
	{
		var uri = GetUriForParamsEmployeeIDAndTerritoryID("Northwind_dbo_EmployeeTerritories/DeleteByEmployeeIDAndTerritoryID", employeeID_IR, territoryID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsEmployeeIDAndTerritoryID(String path, String? employeeID_IR, String territoryID)
	{
		var query = new Dictionary<String,String>();
		query["employeeID_IR"] = employeeID_IR ?? String.Empty;
		query["territoryID"] = territoryID;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
