/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndCommon.Services;
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_BackEndCommon.IndirectReferenceTransformers;
public partial interface IIRTransformers
{
	XE_HR_EMPLOYEES_IR? ToIndirectModel(XE_HR_EMPLOYEES input, Boolean isSecondaryLookup = false);
	XE_HR_EMPLOYEES? ToEntity(XE_HR_EMPLOYEES_IR input, Boolean isSecondaryLookup = false);
}
