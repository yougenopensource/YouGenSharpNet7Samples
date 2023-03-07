/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel.DataAnnotations.Schema;
namespace XE_HR_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: Table Description: employees table. Contains 107 rows. References with departments, jobs, job_history tables. Contains a self reference.
/// </summary>
public class XE_HR_EMPLOYEES 
{
	public XE_HR_EMPLOYEES()
	{
	} 
	public XE_HR_EMPLOYEES(
		Int32 eMPLOYEE_ID_,
		String? fIRST_NAME_,
		String lAST_NAME_,
		String eMAIL_,
		String? pHONE_NUMBER_,
		DateTime hIRE_DATE_,
		String jOB_ID_,
		Decimal? sALARY_,
		Decimal? cOMMISSION_PCT_,
		Int32? mANAGER_ID_,
		Int32? dEPARTMENT_ID_
	)
	{
		EMPLOYEE_ID = eMPLOYEE_ID_;
		FIRST_NAME = fIRST_NAME_;
		LAST_NAME = lAST_NAME_;
		EMAIL = eMAIL_;
		PHONE_NUMBER = pHONE_NUMBER_;
		HIRE_DATE = hIRE_DATE_;
		JOB_ID = jOB_ID_;
		SALARY = sALARY_;
		COMMISSION_PCT = cOMMISSION_PCT_;
		MANAGER_ID = mANAGER_ID_;
		DEPARTMENT_ID = dEPARTMENT_ID_;
	}
	/// <summary>
	/// Primary Key Column
	/// SQL Data Type: NUMBER Chars: 6 Precision: 6 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: Primary key of employees table.
	/// </summary>
	public virtual Int32 EMPLOYEE_ID { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 20 
	/// SQL Default Value: N/A
	/// SQL Column Description: First name of the employee. A not null column.
	/// </summary>
	public virtual String? FIRST_NAME { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 25 
	/// SQL Default Value: N/A
	/// SQL Column Description: Last name of the employee. A not null column.
	/// </summary>
	public virtual String LAST_NAME { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 25 
	/// SQL Default Value: N/A
	/// SQL Column Description: Email id of the employee
	/// </summary>
	public virtual String EMAIL { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 20 
	/// SQL Default Value: N/A
	/// SQL Column Description: Phone number of the employee; includes country code and area code
	/// </summary>
	public virtual String? PHONE_NUMBER { get; set; }
	/// <summary>
	/// SQL Data Type: DATE Chars: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: Date when the employee started on this job. A not null column.
	/// </summary>
	public virtual DateTime HIRE_DATE { get; set; }
	/// <summary>
	/// Foreign Key Column
	/// SQL Data Type: VARCHAR2 Chars: 10 
	/// SQL Default Value: N/A
	/// SQL Column Description: Current job of the employee; foreign key to job_id column of the jobs table. A not null column.
	/// </summary>
	public virtual String JOB_ID { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 9 Precision: 8 Scale: 2 
	/// SQL Default Value: N/A
	/// SQL Column Description: Monthly salary of the employee. Must be greater than zero (enforced by constraint emp_salary_min)
	/// </summary>
	public virtual Decimal? SALARY { get; set; }
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 3 Precision: 2 Scale: 2 
	/// SQL Default Value: N/A
	/// SQL Column Description: Commission percentage of the employee; Only employees in sales department elgible for commission percentage
	/// </summary>
	public virtual Decimal? COMMISSION_PCT { get; set; }
	/// <summary>
	/// Foreign Key Column
	/// SQL Data Type: NUMBER Chars: 6 Precision: 6 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: Manager id of the employee; has same domain as manager_id in departments table. Foreign key to employee_id column of employees table.(useful for reflexive joins and CONNECT BY query)
	/// </summary>
	public virtual Int32? MANAGER_ID { get; set; }
	/// <summary>
	/// Foreign Key Column
	/// SQL Data Type: NUMBER Chars: 4 Precision: 4 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: Department id where employee works; foreign key to department_id column of the departments table
	/// </summary>
	public virtual Int32? DEPARTMENT_ID { get; set; }
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	public virtual XE_HR_DEPARTMENTS? EMP_DEPT_FK_Ref { get; set; }
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	public virtual XE_HR_JOBS? EMP_JOB_FK_Ref { get; set; }
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	public virtual XE_HR_EMPLOYEES? EMP_MANAGER_FK_Ref { get; set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<XE_HR_DEPARTMENTS>?DEPT_MGR_FK_RefBy { get; set; } = new HashSet<XE_HR_DEPARTMENTS>();
	public virtual ICollection<XE_HR_EMPLOYEES>?EMP_MANAGER_FK_RefBy { get; set; } = new HashSet<XE_HR_EMPLOYEES>();
	public virtual ICollection<XE_HR_JOB_HISTORY>?JHIST_EMP_FK_RefBy { get; set; } = new HashSet<XE_HR_JOB_HISTORY>();
}
