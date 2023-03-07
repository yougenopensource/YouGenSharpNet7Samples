/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public interface IXE_HR_DEPARTMENTS_HttpClient
{
	Task<IEnumerable<XE_HR_DEPARTMENTS_IR>?> GetAll();
	Task<IEnumerable<XE_HR_DEPARTMENTS_IR>?> GetByBestMatchedQueryPattern(XE_HR_DEPARTMENTS_IR input);
	Task<IEnumerable<XE_HR_DEPARTMENTS_IR>?> GetByDEPARTMENT_ID(String? dEPARTMENT_ID_IR);
	Task<IEnumerable<XE_HR_DEPARTMENTS_IR>?> GetByLOCATION_ID(String? lOCATION_ID_IR);
	Task<XE_HR_DEPARTMENTS_IR?> Create(XE_HR_DEPARTMENTS_IR input);
	Task UpdateByDEPARTMENT_ID(String? dEPARTMENT_ID_IR, XE_HR_DEPARTMENTS_IR input);
	Task UpdateByLOCATION_ID(String? lOCATION_ID_IR, XE_HR_DEPARTMENTS_IR input);
	Task DeleteByDEPARTMENT_ID(String? dEPARTMENT_ID_IR);
	Task DeleteByLOCATION_ID(String? lOCATION_ID_IR);
}
