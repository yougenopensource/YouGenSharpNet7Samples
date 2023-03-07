/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
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
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public class XE_HR_COUNTRIES_HttpClient : HttpClientBase, IXE_HR_COUNTRIES_HttpClient
{
	public XE_HR_COUNTRIES_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<XE_HR_COUNTRIES_IR>?> GetByBestMatchedQueryPattern(XE_HR_COUNTRIES_IR input)
	{
		if (input == null) return null;
		IEnumerable<XE_HR_COUNTRIES_IR>? retData;
		if (input.COUNTRY_ID_HasBeenChanged) retData = await GetByCOUNTRY_ID(input.COUNTRY_ID ?? String.Empty);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(XE_HR_COUNTRIES_IR record, XE_HR_COUNTRIES_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.COUNTRY_NAME_HasBeenChanged || record.COUNTRY_NAME == filter.COUNTRY_NAME);
	}
	public async Task<IEnumerable<XE_HR_COUNTRIES_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_COUNTRIES/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_COUNTRIES_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_COUNTRIES_IR>?> GetByCOUNTRY_ID(String cOUNTRY_ID)
	{
		var uri = GetUriForParamsCOUNTRY_ID("XE_HR_COUNTRIES/GetByCOUNTRY_ID", cOUNTRY_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_COUNTRIES_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<XE_HR_COUNTRIES_IR?> Create(XE_HR_COUNTRIES_IR input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_COUNTRIES/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<XE_HR_COUNTRIES_IR?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, XE_HR_COUNTRIES_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByCOUNTRY_ID(inputSplits[0], updateModel);
	}
	public async Task UpdateByCOUNTRY_ID(String cOUNTRY_ID, XE_HR_COUNTRIES_IR input)
	{
		var uri = GetUriForParamsCOUNTRY_ID("XE_HR_COUNTRIES/UpdateByCOUNTRY_ID", cOUNTRY_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByCOUNTRY_ID(inputSplits[0]);
	}
	public async Task DeleteByCOUNTRY_ID(String cOUNTRY_ID)
	{
		var uri = GetUriForParamsCOUNTRY_ID("XE_HR_COUNTRIES/DeleteByCOUNTRY_ID", cOUNTRY_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsCOUNTRY_ID(String path, String cOUNTRY_ID)
	{
		var query = new Dictionary<String,String>();
		query["cOUNTRY_ID"] = cOUNTRY_ID;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
