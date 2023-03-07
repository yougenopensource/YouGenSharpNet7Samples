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
public partial class IRTransformers : IIRTransformers
{
	public XE_HR_EMPLOYEES_IR ToIndirectModel(XE_HR_EMPLOYEES input, Boolean isSecondaryLookup = false)
	{
		var retData = new XE_HR_EMPLOYEES_IR(
			eMPLOYEE_ID_IR_ : _encryptionDecryptionService!.EncInt32(input.EMPLOYEE_ID),
			fIRST_NAME_ : input.FIRST_NAME,
			lAST_NAME_ : input.LAST_NAME,
			eMAIL_ : input.EMAIL,
			pHONE_NUMBER_ : input.PHONE_NUMBER,
			hIRE_DATE_ : input.HIRE_DATE,
			jOB_ID_ : input.JOB_ID,
			sALARY_ : input.SALARY,
			cOMMISSION_PCT_ : input.COMMISSION_PCT,
			mANAGER_ID_IR_ : _encryptionDecryptionService!.EncInt32Nullable(input.MANAGER_ID),
			dEPARTMENT_ID_IR_ : _encryptionDecryptionService!.EncInt32Nullable(input.DEPARTMENT_ID)
			);
		if (input.EMP_DEPT_FK_Ref != null) retData.EMP_DEPT_FK_Ref_IR = ToIndirectModel(input.EMP_DEPT_FK_Ref!, true);
		if (input.EMP_JOB_FK_Ref != null) retData.EMP_JOB_FK_Ref_IR = ToIndirectModel(input.EMP_JOB_FK_Ref!, true);
		if (input.EMP_MANAGER_FK_Ref != null) retData.EMP_MANAGER_FK_Ref_IR = ToIndirectModel(input.EMP_MANAGER_FK_Ref!, true);
		if (!isSecondaryLookup && input.DEPT_MGR_FK_RefBy!.Any()) retData.DEPT_MGR_FK_RefBy_IR = input.DEPT_MGR_FK_RefBy!.Select(x => ToIndirectModel(x, true)).ToList()!;
		if (!isSecondaryLookup && input.EMP_MANAGER_FK_RefBy!.Any()) retData.EMP_MANAGER_FK_RefBy_IR = input.EMP_MANAGER_FK_RefBy!.Select(x => ToIndirectModel(x, true)).ToList()!;
		if (!isSecondaryLookup && input.JHIST_EMP_FK_RefBy!.Any()) retData.JHIST_EMP_FK_RefBy_IR = input.JHIST_EMP_FK_RefBy!.Select(x => ToIndirectModel(x, true)).ToList()!;
			retData.PrimaryKeyHashedForUniqueObjectComparison = _encryptionDecryptionService!.CreateHash(retData.EMPLOYEE_ID_IR);
		return retData;
	}
	public XE_HR_EMPLOYEES ToEntity(XE_HR_EMPLOYEES_IR input, Boolean isSecondaryLookup = false)
	{
		var retData = new XE_HR_EMPLOYEES(		
			eMPLOYEE_ID_ : _encryptionDecryptionService.DecInt32(input.EMPLOYEE_ID_IR),
			fIRST_NAME_ : input.FIRST_NAME,
			lAST_NAME_ : input.LAST_NAME ?? String.Empty,
			eMAIL_ : input.EMAIL ?? String.Empty,
			pHONE_NUMBER_ : input.PHONE_NUMBER,
			hIRE_DATE_ : input.HIRE_DATE ?? default,
			jOB_ID_ : input.JOB_ID ?? String.Empty,
			sALARY_ : input.SALARY,
			cOMMISSION_PCT_ : input.COMMISSION_PCT,
			mANAGER_ID_ : _encryptionDecryptionService.DecInt32Nullable(input.MANAGER_ID_IR),
			dEPARTMENT_ID_ : _encryptionDecryptionService.DecInt32Nullable(input.DEPARTMENT_ID_IR)
			);
		if (input.EMP_DEPT_FK_Ref_IR != null) retData.EMP_DEPT_FK_Ref = ToEntity(input.EMP_DEPT_FK_Ref_IR!, true);
		if (input.EMP_JOB_FK_Ref_IR != null) retData.EMP_JOB_FK_Ref = ToEntity(input.EMP_JOB_FK_Ref_IR!, true);
		if (input.EMP_MANAGER_FK_Ref_IR != null) retData.EMP_MANAGER_FK_Ref = ToEntity(input.EMP_MANAGER_FK_Ref_IR!, true);
		return retData;
	}
}
