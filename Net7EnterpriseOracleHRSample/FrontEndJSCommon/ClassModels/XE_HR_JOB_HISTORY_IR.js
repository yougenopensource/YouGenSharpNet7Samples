/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
class XE_HR_JOB_HISTORY_IR {
	constructor(
		EMPLOYEE_ID_IR,
		START_DATE_IR,
		END_DATE,
		JOB_ID,
		DEPARTMENT_ID_IR
	)
	{
		this.EMPLOYEE_ID_IR = EMPLOYEE_ID_IR;
		this.START_DATE_IR = START_DATE_IR;
		this.END_DATE = END_DATE;
		this.JOB_ID = JOB_ID;
		this.DEPARTMENT_ID_IR = DEPARTMENT_ID_IR;
	}
	JHIST_DEPT_FK_Ref_IR;
	JHIST_EMP_FK_Ref_IR;
	JHIST_JOB_FK_Ref_IR;
	EMPLOYEE_ID_IR;
	START_DATE_IR;
	END_DATE;
	JOB_ID;
	DEPARTMENT_ID_IR;
}
