/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_BackEndCommon.RequestHandlers;
public interface IXE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_RequestHandler
{
	//Main Handlers
	Task<XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_IR?> HandleCall_XE_HR_PACKAGE1_PARAMOUTCURSORS<T>(T irModel) where T :XE_HR_PACKAGE1_PARAMOUTCURSORS_IM_IR;
}
