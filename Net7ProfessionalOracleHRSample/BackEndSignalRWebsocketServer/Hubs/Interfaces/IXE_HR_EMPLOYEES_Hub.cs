/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_BackEndSignalRWebsocketServer.Hubs;
public interface IXE_HR_EMPLOYEES_Hub
{
	Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> HandleGeAll();
	Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME);
	Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByDEPARTMENT_ID(String? dEPARTMENT_ID_IR);
	Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByEMAIL(String eMAIL);
	Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByEMPLOYEE_ID(String? eMPLOYEE_ID_IR);
	Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByJOB_ID(String jOB_ID);
	Task<IEnumerable<XE_HR_EMPLOYEES_IR>?> GetByMANAGER_ID(String? mANAGER_ID_IR);
	Task<XE_HR_EMPLOYEES_IR?> HandleCreate(XE_HR_EMPLOYEES_IR input);
	Task UpdateByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME, XE_HR_EMPLOYEES_IR input);
	Task UpdateByDEPARTMENT_ID(String? dEPARTMENT_ID_IR, XE_HR_EMPLOYEES_IR input);
	Task UpdateByEMAIL(String eMAIL, XE_HR_EMPLOYEES_IR input);
	Task UpdateByEMPLOYEE_ID(String? eMPLOYEE_ID_IR, XE_HR_EMPLOYEES_IR input);
	Task UpdateByJOB_ID(String jOB_ID, XE_HR_EMPLOYEES_IR input);
	Task UpdateByMANAGER_ID(String? mANAGER_ID_IR, XE_HR_EMPLOYEES_IR input);
	Task DeleteByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME);
	Task DeleteByDEPARTMENT_ID(String? dEPARTMENT_ID_IR);
	Task DeleteByEMAIL(String eMAIL);
	Task DeleteByEMPLOYEE_ID(String? eMPLOYEE_ID_IR);
	Task DeleteByJOB_ID(String jOB_ID);
	Task DeleteByMANAGER_ID(String? mANAGER_ID_IR);
}
