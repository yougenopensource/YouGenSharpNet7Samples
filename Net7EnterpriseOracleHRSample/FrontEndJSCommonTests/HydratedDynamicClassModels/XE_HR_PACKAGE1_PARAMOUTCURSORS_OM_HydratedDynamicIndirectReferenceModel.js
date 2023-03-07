/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedDynamicXE_HR_PACKAGE1_PARAMOUTCURSORS(fillPrimaryKey = false) {
	var retObj = new XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_IR();
		// Output parameters
	retObj.CONVERTED_TO_VARCHAR2 = generateString(100);
	retObj.Query1_Results_IR.ToList().push({});
	retObj.query1_Results_IR[0].EMPLOYEE_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.query1_Results[0].START_DATE = generateString(7);
	retObj.query1_Results[0].END_DATE = generateString(7);
	retObj.query1_Results[0].JOB_ID = generateString(10);
	retObj.query1_Results_IR[0].DEPARTMENT_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.Query2_Results_IR.ToList().push({});
	retObj.query2_Results_IR[0].DEPARTMENT_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.query2_Results[0].DEPARTMENT_NAME = generateString(30);
	retObj.query2_Results_IR[0].MANAGER_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.query2_Results_IR[0].LOCATION_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	return retObj;
}
