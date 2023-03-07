/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace XE_HR_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Model Description: Stored Procedure Output Model Query 1
/// </summary>
public class XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query1_IR
{
	public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query1_IR() 
	{
	} 
	public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query1_IR(
		String? eMPLOYEE_ID_IR_,
		String? fIRST_NAME_,
		String lAST_NAME_,
		String eMAIL_,
		String? pHONE_NUMBER_,
		String hIRE_DATE_,
		String jOB_ID_,
		Decimal? sALARY_,
		Decimal? cOMMISSION_PCT_,
		String? mANAGER_ID_IR_,
		String? dEPARTMENT_ID_IR_
	)
	{
		EMPLOYEE_ID_IR = eMPLOYEE_ID_IR_;
		FIRST_NAME = fIRST_NAME_;
		LAST_NAME = lAST_NAME_;
		EMAIL = eMAIL_;
		PHONE_NUMBER = pHONE_NUMBER_;
		HIRE_DATE = hIRE_DATE_;
		JOB_ID = jOB_ID_;
		SALARY = sALARY_;
		COMMISSION_PCT = cOMMISSION_PCT_;
		MANAGER_ID_IR = mANAGER_ID_IR_;
		DEPARTMENT_ID_IR = dEPARTMENT_ID_IR_;
	}
	[JsonConstructor]
	public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query1_IR(
		String? EMPLOYEE_ID_IR,
		String? EMPLOYEE_ID_IR_OriginalValue,
		Boolean EMPLOYEE_ID_IR_HasBeenChanged,
		String? FIRST_NAME,
		String? FIRST_NAME_OriginalValue,
		Boolean FIRST_NAME_HasBeenChanged,
		String? LAST_NAME,
		String? LAST_NAME_OriginalValue,
		Boolean LAST_NAME_HasBeenChanged,
		String? EMAIL,
		String? EMAIL_OriginalValue,
		Boolean EMAIL_HasBeenChanged,
		String? PHONE_NUMBER,
		String? PHONE_NUMBER_OriginalValue,
		Boolean PHONE_NUMBER_HasBeenChanged,
		String? HIRE_DATE,
		String? HIRE_DATE_OriginalValue,
		Boolean HIRE_DATE_HasBeenChanged,
		String? JOB_ID,
		String? JOB_ID_OriginalValue,
		Boolean JOB_ID_HasBeenChanged,
		Decimal? SALARY,
		Decimal? SALARY_OriginalValue,
		Boolean SALARY_HasBeenChanged,
		Decimal? COMMISSION_PCT,
		Decimal? COMMISSION_PCT_OriginalValue,
		Boolean COMMISSION_PCT_HasBeenChanged,
		String? MANAGER_ID_IR,
		String? MANAGER_ID_IR_OriginalValue,
		Boolean MANAGER_ID_IR_HasBeenChanged,
		String? DEPARTMENT_ID_IR,
		String? DEPARTMENT_ID_IR_OriginalValue,
		Boolean DEPARTMENT_ID_IR_HasBeenChanged
	)
	{
		this.EMPLOYEE_ID_IR = EMPLOYEE_ID_IR;
		this.EMPLOYEE_ID_IR_OriginalValue = EMPLOYEE_ID_IR_OriginalValue;
		this.EMPLOYEE_ID_IR_HasBeenChanged = EMPLOYEE_ID_IR_HasBeenChanged;
		this.FIRST_NAME = FIRST_NAME;
		this.FIRST_NAME_OriginalValue = FIRST_NAME_OriginalValue;
		this.FIRST_NAME_HasBeenChanged = FIRST_NAME_HasBeenChanged;
		this.LAST_NAME = LAST_NAME;
		this.LAST_NAME_OriginalValue = LAST_NAME_OriginalValue;
		this.LAST_NAME_HasBeenChanged = LAST_NAME_HasBeenChanged;
		this.EMAIL = EMAIL;
		this.EMAIL_OriginalValue = EMAIL_OriginalValue;
		this.EMAIL_HasBeenChanged = EMAIL_HasBeenChanged;
		this.PHONE_NUMBER = PHONE_NUMBER;
		this.PHONE_NUMBER_OriginalValue = PHONE_NUMBER_OriginalValue;
		this.PHONE_NUMBER_HasBeenChanged = PHONE_NUMBER_HasBeenChanged;
		this.HIRE_DATE = HIRE_DATE;
		this.HIRE_DATE_OriginalValue = HIRE_DATE_OriginalValue;
		this.HIRE_DATE_HasBeenChanged = HIRE_DATE_HasBeenChanged;
		this.JOB_ID = JOB_ID;
		this.JOB_ID_OriginalValue = JOB_ID_OriginalValue;
		this.JOB_ID_HasBeenChanged = JOB_ID_HasBeenChanged;
		this.SALARY = SALARY;
		this.SALARY_OriginalValue = SALARY_OriginalValue;
		this.SALARY_HasBeenChanged = SALARY_HasBeenChanged;
		this.COMMISSION_PCT = COMMISSION_PCT;
		this.COMMISSION_PCT_OriginalValue = COMMISSION_PCT_OriginalValue;
		this.COMMISSION_PCT_HasBeenChanged = COMMISSION_PCT_HasBeenChanged;
		this.MANAGER_ID_IR = MANAGER_ID_IR;
		this.MANAGER_ID_IR_OriginalValue = MANAGER_ID_IR_OriginalValue;
		this.MANAGER_ID_IR_HasBeenChanged = MANAGER_ID_IR_HasBeenChanged;
		this.DEPARTMENT_ID_IR = DEPARTMENT_ID_IR;
		this.DEPARTMENT_ID_IR_OriginalValue = DEPARTMENT_ID_IR_OriginalValue;
		this.DEPARTMENT_ID_IR_HasBeenChanged = DEPARTMENT_ID_IR_HasBeenChanged;
	}
	public String? EMPLOYEE_ID_IR
	{
		get => _eMPLOYEE_ID_IR;
		set
		{
			_eMPLOYEE_ID_IR = value;
			EMPLOYEE_ID_IR_HasBeenChanged = _eMPLOYEE_ID_IR == EMPLOYEE_ID_IR_OriginalValue ? false : true;
		}
	}
	private String? _eMPLOYEE_ID_IR;
	public String? EMPLOYEE_ID_IR_OriginalValue { get; private set; }
	public Boolean EMPLOYEE_ID_IR_HasBeenChanged { get; private set; }
	public String? FIRST_NAME
	{
		get => _fIRST_NAME;
		set
		{
			_fIRST_NAME = value;
			FIRST_NAME_HasBeenChanged = _fIRST_NAME == FIRST_NAME_OriginalValue ? false : true;
		}
	}
	private String? _fIRST_NAME;
	public String? FIRST_NAME_OriginalValue { get; private set; }
	public Boolean FIRST_NAME_HasBeenChanged { get; private set; }
	public String? LAST_NAME
	{
		get => _lAST_NAME;
		set
		{
			_lAST_NAME = value;
			LAST_NAME_HasBeenChanged = _lAST_NAME == LAST_NAME_OriginalValue ? false : true;
		}
	}
	private String? _lAST_NAME;
	public String? LAST_NAME_OriginalValue { get; private set; }
	public Boolean LAST_NAME_HasBeenChanged { get; private set; }
	public String? EMAIL
	{
		get => _eMAIL;
		set
		{
			_eMAIL = value;
			EMAIL_HasBeenChanged = _eMAIL == EMAIL_OriginalValue ? false : true;
		}
	}
	private String? _eMAIL;
	public String? EMAIL_OriginalValue { get; private set; }
	public Boolean EMAIL_HasBeenChanged { get; private set; }
	public String? PHONE_NUMBER
	{
		get => _pHONE_NUMBER;
		set
		{
			_pHONE_NUMBER = value;
			PHONE_NUMBER_HasBeenChanged = _pHONE_NUMBER == PHONE_NUMBER_OriginalValue ? false : true;
		}
	}
	private String? _pHONE_NUMBER;
	public String? PHONE_NUMBER_OriginalValue { get; private set; }
	public Boolean PHONE_NUMBER_HasBeenChanged { get; private set; }
	public String? HIRE_DATE
	{
		get => _hIRE_DATE;
		set
		{
			_hIRE_DATE = value;
			HIRE_DATE_HasBeenChanged = _hIRE_DATE == HIRE_DATE_OriginalValue ? false : true;
		}
	}
	private String? _hIRE_DATE;
	public String? HIRE_DATE_OriginalValue { get; private set; }
	public Boolean HIRE_DATE_HasBeenChanged { get; private set; }
	public String? JOB_ID
	{
		get => _jOB_ID;
		set
		{
			_jOB_ID = value;
			JOB_ID_HasBeenChanged = _jOB_ID == JOB_ID_OriginalValue ? false : true;
		}
	}
	private String? _jOB_ID;
	public String? JOB_ID_OriginalValue { get; private set; }
	public Boolean JOB_ID_HasBeenChanged { get; private set; }
	public Decimal? SALARY
	{
		get => _sALARY;
		set
		{
			_sALARY = value;
			SALARY_HasBeenChanged = _sALARY == SALARY_OriginalValue ? false : true;
		}
	}
	private Decimal? _sALARY;
	public Decimal? SALARY_OriginalValue { get; private set; }
	public Boolean SALARY_HasBeenChanged { get; private set; }
	public Decimal? COMMISSION_PCT
	{
		get => _cOMMISSION_PCT;
		set
		{
			_cOMMISSION_PCT = value;
			COMMISSION_PCT_HasBeenChanged = _cOMMISSION_PCT == COMMISSION_PCT_OriginalValue ? false : true;
		}
	}
	private Decimal? _cOMMISSION_PCT;
	public Decimal? COMMISSION_PCT_OriginalValue { get; private set; }
	public Boolean COMMISSION_PCT_HasBeenChanged { get; private set; }
	public String? MANAGER_ID_IR
	{
		get => _mANAGER_ID_IR;
		set
		{
			_mANAGER_ID_IR = value;
			MANAGER_ID_IR_HasBeenChanged = _mANAGER_ID_IR == MANAGER_ID_IR_OriginalValue ? false : true;
		}
	}
	private String? _mANAGER_ID_IR;
	public String? MANAGER_ID_IR_OriginalValue { get; private set; }
	public Boolean MANAGER_ID_IR_HasBeenChanged { get; private set; }
	public String? DEPARTMENT_ID_IR
	{
		get => _dEPARTMENT_ID_IR;
		set
		{
			_dEPARTMENT_ID_IR = value;
			DEPARTMENT_ID_IR_HasBeenChanged = _dEPARTMENT_ID_IR == DEPARTMENT_ID_IR_OriginalValue ? false : true;
		}
	}
	private String? _dEPARTMENT_ID_IR;
	public String? DEPARTMENT_ID_IR_OriginalValue { get; private set; }
	public Boolean DEPARTMENT_ID_IR_HasBeenChanged { get; private set; }
}
