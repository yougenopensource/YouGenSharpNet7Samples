/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202757 on behalf of: ****
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
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public class XE_HR_DEPARTMENTS_HttpClient : HttpClientBase, IXE_HR_DEPARTMENTS_HttpClient
{
	public XE_HR_DEPARTMENTS_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<XE_HR_DEPARTMENTS>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_DEPARTMENTS/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_DEPARTMENTS>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_DEPARTMENTS>?> GetByDEPARTMENT_ID(Int32 dEPARTMENT_ID)
	{
		var uri = GetUriForParamsDEPARTMENT_ID("XE_HR_DEPARTMENTS/GetByDEPARTMENT_ID", dEPARTMENT_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_DEPARTMENTS>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_DEPARTMENTS>?> GetByLOCATION_ID(Int32? lOCATION_ID)
	{
		var uri = GetUriForParamsLOCATION_ID("XE_HR_DEPARTMENTS/GetByLOCATION_ID", lOCATION_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_DEPARTMENTS>?>(content, _jsonSerializationSettings);
	}
	public async Task<XE_HR_DEPARTMENTS?> Create(XE_HR_DEPARTMENTS input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_DEPARTMENTS/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<XE_HR_DEPARTMENTS?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, XE_HR_DEPARTMENTS updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByDEPARTMENT_ID(Convert.ToInt32(inputSplits[0]), updateModel);
	}
	public async Task UpdateByDEPARTMENT_ID(Int32 dEPARTMENT_ID, XE_HR_DEPARTMENTS input)
	{
		var uri = GetUriForParamsDEPARTMENT_ID("XE_HR_DEPARTMENTS/UpdateByDEPARTMENT_ID", dEPARTMENT_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByLOCATION_ID(Int32? lOCATION_ID, XE_HR_DEPARTMENTS input)
	{
		var uri = GetUriForParamsLOCATION_ID("XE_HR_DEPARTMENTS/UpdateByLOCATION_ID", lOCATION_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByDEPARTMENT_ID(Convert.ToInt32(inputSplits[0]));
	}
	public async Task DeleteByDEPARTMENT_ID(Int32 dEPARTMENT_ID)
	{
		var uri = GetUriForParamsDEPARTMENT_ID("XE_HR_DEPARTMENTS/DeleteByDEPARTMENT_ID", dEPARTMENT_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByLOCATION_ID(Int32? lOCATION_ID)
	{
		var uri = GetUriForParamsLOCATION_ID("XE_HR_DEPARTMENTS/DeleteByLOCATION_ID", lOCATION_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsDEPARTMENT_ID(String path, Int32 dEPARTMENT_ID)
	{
		var query = new Dictionary<String,String>();
		query["dEPARTMENT_ID"] = dEPARTMENT_ID.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsLOCATION_ID(String path, Int32? lOCATION_ID)
	{
		var query = new Dictionary<String,String>();
		query["lOCATION_ID"] = lOCATION_ID.ToString() ?? 0.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
