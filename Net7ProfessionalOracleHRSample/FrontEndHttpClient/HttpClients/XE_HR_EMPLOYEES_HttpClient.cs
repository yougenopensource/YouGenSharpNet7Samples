/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public class XE_HR_EMPLOYEES_HttpClient : HttpClientBase, IXE_HR_EMPLOYEES_HttpClient
{
	public XE_HR_EMPLOYEES_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByBestMatchedQueryPattern(XE_HR_EMPLOYEES_IR input)
	{
		if (input == null) return null;
		IEnumerable<XE_HR_EMPLOYEES_IR>? retData;
		if (input.FIRST_NAME_HasBeenChanged && input.LAST_NAME_HasBeenChanged) retData = await GetByFIRST_NAMEAndLAST_NAME(input.FIRST_NAME, input.LAST_NAME ?? String.Empty);
		else if (input.DEPARTMENT_ID_IR_HasBeenChanged) retData = await GetByDEPARTMENT_ID(input.DEPARTMENT_ID_IR);
		else if (input.EMAIL_HasBeenChanged) retData = await GetByEMAIL(input.EMAIL ?? String.Empty);
		else if (input.EMPLOYEE_ID_IR_HasBeenChanged) retData = await GetByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? default);
		else if (input.JOB_ID_HasBeenChanged) retData = await GetByJOB_ID(input.JOB_ID ?? String.Empty);
		else if (input.MANAGER_ID_IR_HasBeenChanged) retData = await GetByMANAGER_ID(input.MANAGER_ID_IR);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(XE_HR_EMPLOYEES_IR record, XE_HR_EMPLOYEES_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.FIRST_NAME_HasBeenChanged || record.FIRST_NAME == filter.FIRST_NAME) &&
			(!filter.LAST_NAME_HasBeenChanged || record.LAST_NAME == filter.LAST_NAME) &&
			(!filter.EMAIL_HasBeenChanged || record.EMAIL == filter.EMAIL) &&
			(!filter.PHONE_NUMBER_HasBeenChanged || record.PHONE_NUMBER == filter.PHONE_NUMBER) &&
			(!filter.HIRE_DATE_HasBeenChanged || record.HIRE_DATE == filter.HIRE_DATE);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_EMPLOYEES/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME)
	{
		var uri = GetUriForParamsFIRST_NAMEAndLAST_NAME("XE_HR_EMPLOYEES/GetByFIRST_NAMEAndLAST_NAME", fIRST_NAME, lAST_NAME);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByDEPARTMENT_ID(String? dEPARTMENT_ID_IR)
	{
		var uri = GetUriForParamsDEPARTMENT_ID("XE_HR_EMPLOYEES/GetByDEPARTMENT_ID", dEPARTMENT_ID_IR);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByEMAIL(String eMAIL)
	{
		var uri = GetUriForParamsEMAIL("XE_HR_EMPLOYEES/GetByEMAIL", eMAIL);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByEMPLOYEE_ID(String? eMPLOYEE_ID_IR)
	{
		var uri = GetUriForParamsEMPLOYEE_ID("XE_HR_EMPLOYEES/GetByEMPLOYEE_ID", eMPLOYEE_ID_IR);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByJOB_ID(String jOB_ID)
	{
		var uri = GetUriForParamsJOB_ID("XE_HR_EMPLOYEES/GetByJOB_ID", jOB_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByMANAGER_ID(String? mANAGER_ID_IR)
	{
		var uri = GetUriForParamsMANAGER_ID("XE_HR_EMPLOYEES/GetByMANAGER_ID", mANAGER_ID_IR);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_EMPLOYEES_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<XE_HR_EMPLOYEES_IR?> Create(XE_HR_EMPLOYEES_IR input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_EMPLOYEES/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<XE_HR_EMPLOYEES_IR?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, XE_HR_EMPLOYEES_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByEMPLOYEE_ID(inputSplits[0], updateModel);
	}
	public async Task UpdateByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME, XE_HR_EMPLOYEES_IR input)
	{
		var uri = GetUriForParamsFIRST_NAMEAndLAST_NAME("XE_HR_EMPLOYEES/UpdateByFIRST_NAMEAndLAST_NAME", fIRST_NAME, lAST_NAME);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByDEPARTMENT_ID(String? dEPARTMENT_ID_IR, XE_HR_EMPLOYEES_IR input)
	{
		var uri = GetUriForParamsDEPARTMENT_ID("XE_HR_EMPLOYEES/UpdateByDEPARTMENT_ID", dEPARTMENT_ID_IR);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByEMAIL(String eMAIL, XE_HR_EMPLOYEES_IR input)
	{
		var uri = GetUriForParamsEMAIL("XE_HR_EMPLOYEES/UpdateByEMAIL", eMAIL);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByEMPLOYEE_ID(String? eMPLOYEE_ID_IR, XE_HR_EMPLOYEES_IR input)
	{
		var uri = GetUriForParamsEMPLOYEE_ID("XE_HR_EMPLOYEES/UpdateByEMPLOYEE_ID", eMPLOYEE_ID_IR);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByJOB_ID(String jOB_ID, XE_HR_EMPLOYEES_IR input)
	{
		var uri = GetUriForParamsJOB_ID("XE_HR_EMPLOYEES/UpdateByJOB_ID", jOB_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByMANAGER_ID(String? mANAGER_ID_IR, XE_HR_EMPLOYEES_IR input)
	{
		var uri = GetUriForParamsMANAGER_ID("XE_HR_EMPLOYEES/UpdateByMANAGER_ID", mANAGER_ID_IR);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByEMPLOYEE_ID(inputSplits[0]);
	}
	public async Task DeleteByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME)
	{
		var uri = GetUriForParamsFIRST_NAMEAndLAST_NAME("XE_HR_EMPLOYEES/DeleteByFIRST_NAMEAndLAST_NAME", fIRST_NAME, lAST_NAME);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByDEPARTMENT_ID(String? dEPARTMENT_ID_IR)
	{
		var uri = GetUriForParamsDEPARTMENT_ID("XE_HR_EMPLOYEES/DeleteByDEPARTMENT_ID", dEPARTMENT_ID_IR);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEMAIL(String eMAIL)
	{
		var uri = GetUriForParamsEMAIL("XE_HR_EMPLOYEES/DeleteByEMAIL", eMAIL);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEMPLOYEE_ID(String? eMPLOYEE_ID_IR)
	{
		var uri = GetUriForParamsEMPLOYEE_ID("XE_HR_EMPLOYEES/DeleteByEMPLOYEE_ID", eMPLOYEE_ID_IR);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByJOB_ID(String jOB_ID)
	{
		var uri = GetUriForParamsJOB_ID("XE_HR_EMPLOYEES/DeleteByJOB_ID", jOB_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByMANAGER_ID(String? mANAGER_ID_IR)
	{
		var uri = GetUriForParamsMANAGER_ID("XE_HR_EMPLOYEES/DeleteByMANAGER_ID", mANAGER_ID_IR);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsFIRST_NAMEAndLAST_NAME(String path, String? fIRST_NAME, String lAST_NAME)
	{
		var query = new Dictionary<String,String>();
		query["fIRST_NAME"] = fIRST_NAME ?? String.Empty;
		query["lAST_NAME"] = lAST_NAME;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsDEPARTMENT_ID(String path, String? dEPARTMENT_ID_IR)
	{
		var query = new Dictionary<String,String>();
		query["dEPARTMENT_ID_IR"] = dEPARTMENT_ID_IR ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsEMAIL(String path, String eMAIL)
	{
		var query = new Dictionary<String,String>();
		query["eMAIL"] = eMAIL;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsEMPLOYEE_ID(String path, String? eMPLOYEE_ID_IR)
	{
		var query = new Dictionary<String,String>();
		query["eMPLOYEE_ID_IR"] = eMPLOYEE_ID_IR ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsJOB_ID(String path, String jOB_ID)
	{
		var query = new Dictionary<String,String>();
		query["jOB_ID"] = jOB_ID;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsMANAGER_ID(String path, String? mANAGER_ID_IR)
	{
		var query = new Dictionary<String,String>();
		query["mANAGER_ID_IR"] = mANAGER_ID_IR ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
