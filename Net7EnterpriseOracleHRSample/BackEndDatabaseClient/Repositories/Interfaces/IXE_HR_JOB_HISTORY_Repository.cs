/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClient.Repositories;
public interface IXE_HR_JOB_HISTORY_Repository : IGenericTableRepository<XE_HR_JOB_HISTORY>
{
	Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetByEMPLOYEE_IDAndSTART_DATE(Int32 eMPLOYEE_ID_, DateTime sTART_DATE_);
	Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetByDEPARTMENT_ID(Int32? dEPARTMENT_ID_);
	Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetByEMPLOYEE_ID(Int32 eMPLOYEE_ID_);
	Task<IEnumerable<XE_HR_JOB_HISTORY>?> GetByJOB_ID(String jOB_ID_);
	Task UpdateByEMPLOYEE_IDAndSTART_DATE(Int32 eMPLOYEE_ID_, DateTime sTART_DATE_, XE_HR_JOB_HISTORY entity);
	Task UpdateByDEPARTMENT_ID(Int32? dEPARTMENT_ID_, XE_HR_JOB_HISTORY entity);
	Task UpdateByEMPLOYEE_ID(Int32 eMPLOYEE_ID_, XE_HR_JOB_HISTORY entity);
	Task UpdateByJOB_ID(String jOB_ID_, XE_HR_JOB_HISTORY entity);
	Task DeleteByEMPLOYEE_IDAndSTART_DATE(Int32 eMPLOYEE_ID_, DateTime sTART_DATE_);
	Task DeleteByDEPARTMENT_ID(Int32? dEPARTMENT_ID_);
	Task DeleteByEMPLOYEE_ID(Int32 eMPLOYEE_ID_);
	Task DeleteByJOB_ID(String jOB_ID_);
}
