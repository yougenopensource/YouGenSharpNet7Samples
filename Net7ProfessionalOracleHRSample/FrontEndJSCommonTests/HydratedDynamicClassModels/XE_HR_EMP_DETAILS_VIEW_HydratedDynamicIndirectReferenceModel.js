/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedDynamicXE_HR_EMP_DETAILS_VIEW(fillPrimaryKey = false) {
	let retObj = new XE_HR_EMP_DETAILS_VIEW_IR();
	retObj.EMPLOYEE_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.JOB_ID = (fillPrimaryKey ? generateString(10) : null);
	retObj.MANAGER_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.DEPARTMENT_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.LOCATION_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.COUNTRY_ID = (fillPrimaryKey ? generateString(2) : null);
	retObj.FIRST_NAME = generateString(20);
	retObj.LAST_NAME = generateString(25);
	retObj.SALARY = generateDecimal(8,2);
	retObj.COMMISSION_PCT = generateDecimal(2,2);
	retObj.DEPARTMENT_NAME = generateString(30);
	retObj.JOB_TITLE = generateString(35);
	retObj.CITY = generateString(30);
	retObj.STATE_PROVINCE = generateString(25);
	retObj.COUNTRY_NAME = generateString(40);
	retObj.REGION_NAME = generateString(25);
	return retObj;
}
