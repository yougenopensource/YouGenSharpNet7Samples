/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClient.Repositories;
public interface IXE_HR_EMPLOYEES_Repository : IGenericTableRepository<XE_HR_EMPLOYEES>
{
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME_, String lAST_NAME_);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByDEPARTMENT_ID(Int32? dEPARTMENT_ID_);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByEMAIL(String eMAIL_);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByEMPLOYEE_ID(Int32 eMPLOYEE_ID_);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByJOB_ID(String jOB_ID_);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByMANAGER_ID(Int32? mANAGER_ID_);
	Task UpdateByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME_, String lAST_NAME_, XE_HR_EMPLOYEES entity);
	Task UpdateByDEPARTMENT_ID(Int32? dEPARTMENT_ID_, XE_HR_EMPLOYEES entity);
	Task UpdateByEMAIL(String eMAIL_, XE_HR_EMPLOYEES entity);
	Task UpdateByEMPLOYEE_ID(Int32 eMPLOYEE_ID_, XE_HR_EMPLOYEES entity);
	Task UpdateByJOB_ID(String jOB_ID_, XE_HR_EMPLOYEES entity);
	Task UpdateByMANAGER_ID(Int32? mANAGER_ID_, XE_HR_EMPLOYEES entity);
	Task DeleteByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME_, String lAST_NAME_);
	Task DeleteByDEPARTMENT_ID(Int32? dEPARTMENT_ID_);
	Task DeleteByEMAIL(String eMAIL_);
	Task DeleteByEMPLOYEE_ID(Int32 eMPLOYEE_ID_);
	Task DeleteByJOB_ID(String jOB_ID_);
	Task DeleteByMANAGER_ID(Int32? mANAGER_ID_);
}
