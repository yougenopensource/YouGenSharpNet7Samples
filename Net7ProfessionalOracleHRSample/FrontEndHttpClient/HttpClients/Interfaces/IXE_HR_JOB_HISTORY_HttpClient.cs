/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public interface IXE_HR_JOB_HISTORY_HttpClient
{
	Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetAll();
	Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByBestMatchedQueryPattern(XE_HR_JOB_HISTORY_IR input);
	Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByEMPLOYEE_IDAndSTART_DATE(String? eMPLOYEE_ID_IR, DateTime sTART_DATE);
	Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByDEPARTMENT_ID(String? dEPARTMENT_ID_IR);
	Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByEMPLOYEE_ID(String? eMPLOYEE_ID_IR);
	Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByJOB_ID(String jOB_ID);
	Task<XE_HR_JOB_HISTORY_IR?> Create(XE_HR_JOB_HISTORY_IR input);
	Task UpdateByEMPLOYEE_IDAndSTART_DATE(String? eMPLOYEE_ID_IR, DateTime sTART_DATE, XE_HR_JOB_HISTORY_IR input);
	Task UpdateByDEPARTMENT_ID(String? dEPARTMENT_ID_IR, XE_HR_JOB_HISTORY_IR input);
	Task UpdateByEMPLOYEE_ID(String? eMPLOYEE_ID_IR, XE_HR_JOB_HISTORY_IR input);
	Task UpdateByJOB_ID(String jOB_ID, XE_HR_JOB_HISTORY_IR input);
	Task DeleteByEMPLOYEE_IDAndSTART_DATE(String? eMPLOYEE_ID_IR, DateTime sTART_DATE);
	Task DeleteByDEPARTMENT_ID(String? dEPARTMENT_ID_IR);
	Task DeleteByEMPLOYEE_ID(String? eMPLOYEE_ID_IR);
	Task DeleteByJOB_ID(String jOB_ID);
}
