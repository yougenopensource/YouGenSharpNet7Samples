/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedStaticXE_HR_DEPARTMENTS(fillPrimaryKey = false) {
	let retObj = new XE_HR_DEPARTMENTS_IR();
	retObj.DEPARTMENT_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.DEPARTMENT_NAME = 'pCCndVo1YRGETIf9uZE8SufJV25meA';
	retObj.MANAGER_ID_IR = encrypt(1);
	retObj.LOCATION_ID_IR = encrypt(1);
	// Foreign key entities
	retObj.DEPT_LOC_FK_Ref_IR = getHydratedStaticXE_HR_LOCATIONS_IR();
	retObj.DEPT_MGR_FK_Ref_IR = getHydratedStaticXE_HR_EMPLOYEES_IR();
	return retObj;
}
