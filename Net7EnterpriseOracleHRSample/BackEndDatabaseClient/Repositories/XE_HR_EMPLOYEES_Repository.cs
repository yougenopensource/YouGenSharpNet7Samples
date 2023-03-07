/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
using XE_HR_BackEndDatabaseClient;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClient.Repositories;
public class XE_HR_EMPLOYEES_Repository : GenericTableRepository<XE_HR_EMPLOYEES>, IXE_HR_EMPLOYEES_Repository
{
    private readonly ILogger<XE_HR_EMPLOYEES_Repository> _logger;    
    public XE_HR_EMPLOYEES_Repository
    (
        ILogger<XE_HR_EMPLOYEES_Repository> logger
        ,XE_HR_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME_, String lAST_NAME_)
	{
		return await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.FIRST_NAME == fIRST_NAME_ && x.LAST_NAME == lAST_NAME_)
			.Include(x => x.EMP_DEPT_FK_Ref)
			.Include(x => x.EMP_JOB_FK_Ref)
			.Include(x => x.EMP_MANAGER_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByDEPARTMENT_ID(Int32? dEPARTMENT_ID_)
	{
		return await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.DEPARTMENT_ID == dEPARTMENT_ID_)
			.Include(x => x.EMP_DEPT_FK_Ref)
			.Include(x => x.EMP_JOB_FK_Ref)
			.Include(x => x.EMP_MANAGER_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByEMAIL(String eMAIL_)
	{
		return await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.EMAIL == eMAIL_)
			.Include(x => x.EMP_DEPT_FK_Ref)
			.Include(x => x.EMP_JOB_FK_Ref)
			.Include(x => x.EMP_MANAGER_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByEMPLOYEE_ID(Int32 eMPLOYEE_ID_)
	{
		return await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.EMPLOYEE_ID == eMPLOYEE_ID_)
			.Include(x => x.EMP_DEPT_FK_Ref)
			.Include(x => x.EMP_JOB_FK_Ref)
			.Include(x => x.EMP_MANAGER_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByJOB_ID(String jOB_ID_)
	{
		return await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.JOB_ID == jOB_ID_)
			.Include(x => x.EMP_DEPT_FK_Ref)
			.Include(x => x.EMP_JOB_FK_Ref)
			.Include(x => x.EMP_MANAGER_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<XE_HR_EMPLOYEES>?> GetByMANAGER_ID(Int32? mANAGER_ID_)
	{
		return await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.MANAGER_ID == mANAGER_ID_)
			.Include(x => x.EMP_DEPT_FK_Ref)
			.Include(x => x.EMP_JOB_FK_Ref)
			.Include(x => x.EMP_MANAGER_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME_, String lAST_NAME_, XE_HR_EMPLOYEES entity)
	{
		await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.FIRST_NAME == fIRST_NAME_ && x.LAST_NAME == lAST_NAME_)
			.UpdateFromQueryAsync(x => new XE_HR_EMPLOYEES(){ FIRST_NAME = entity.FIRST_NAME, LAST_NAME = entity.LAST_NAME, EMAIL = entity.EMAIL, PHONE_NUMBER = entity.PHONE_NUMBER, HIRE_DATE = entity.HIRE_DATE, JOB_ID = entity.JOB_ID, SALARY = entity.SALARY, COMMISSION_PCT = entity.COMMISSION_PCT, MANAGER_ID = entity.MANAGER_ID, DEPARTMENT_ID = entity.DEPARTMENT_ID });
	}
	public async Task UpdateByDEPARTMENT_ID(Int32? dEPARTMENT_ID_, XE_HR_EMPLOYEES entity)
	{
		await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.DEPARTMENT_ID == dEPARTMENT_ID_)
			.UpdateFromQueryAsync(x => new XE_HR_EMPLOYEES(){ FIRST_NAME = entity.FIRST_NAME, LAST_NAME = entity.LAST_NAME, EMAIL = entity.EMAIL, PHONE_NUMBER = entity.PHONE_NUMBER, HIRE_DATE = entity.HIRE_DATE, JOB_ID = entity.JOB_ID, SALARY = entity.SALARY, COMMISSION_PCT = entity.COMMISSION_PCT, MANAGER_ID = entity.MANAGER_ID, DEPARTMENT_ID = entity.DEPARTMENT_ID });
	}
	public async Task UpdateByEMAIL(String eMAIL_, XE_HR_EMPLOYEES entity)
	{
		await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.EMAIL == eMAIL_)
			.UpdateFromQueryAsync(x => new XE_HR_EMPLOYEES(){ FIRST_NAME = entity.FIRST_NAME, LAST_NAME = entity.LAST_NAME, EMAIL = entity.EMAIL, PHONE_NUMBER = entity.PHONE_NUMBER, HIRE_DATE = entity.HIRE_DATE, JOB_ID = entity.JOB_ID, SALARY = entity.SALARY, COMMISSION_PCT = entity.COMMISSION_PCT, MANAGER_ID = entity.MANAGER_ID, DEPARTMENT_ID = entity.DEPARTMENT_ID });
	}
	public async Task UpdateByEMPLOYEE_ID(Int32 eMPLOYEE_ID_, XE_HR_EMPLOYEES entity)
	{
		await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.EMPLOYEE_ID == eMPLOYEE_ID_)
			.UpdateFromQueryAsync(x => new XE_HR_EMPLOYEES(){ FIRST_NAME = entity.FIRST_NAME, LAST_NAME = entity.LAST_NAME, EMAIL = entity.EMAIL, PHONE_NUMBER = entity.PHONE_NUMBER, HIRE_DATE = entity.HIRE_DATE, JOB_ID = entity.JOB_ID, SALARY = entity.SALARY, COMMISSION_PCT = entity.COMMISSION_PCT, MANAGER_ID = entity.MANAGER_ID, DEPARTMENT_ID = entity.DEPARTMENT_ID });
	}
	public async Task UpdateByJOB_ID(String jOB_ID_, XE_HR_EMPLOYEES entity)
	{
		await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.JOB_ID == jOB_ID_)
			.UpdateFromQueryAsync(x => new XE_HR_EMPLOYEES(){ FIRST_NAME = entity.FIRST_NAME, LAST_NAME = entity.LAST_NAME, EMAIL = entity.EMAIL, PHONE_NUMBER = entity.PHONE_NUMBER, HIRE_DATE = entity.HIRE_DATE, JOB_ID = entity.JOB_ID, SALARY = entity.SALARY, COMMISSION_PCT = entity.COMMISSION_PCT, MANAGER_ID = entity.MANAGER_ID, DEPARTMENT_ID = entity.DEPARTMENT_ID });
	}
	public async Task UpdateByMANAGER_ID(Int32? mANAGER_ID_, XE_HR_EMPLOYEES entity)
	{
		await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.MANAGER_ID == mANAGER_ID_)
			.UpdateFromQueryAsync(x => new XE_HR_EMPLOYEES(){ FIRST_NAME = entity.FIRST_NAME, LAST_NAME = entity.LAST_NAME, EMAIL = entity.EMAIL, PHONE_NUMBER = entity.PHONE_NUMBER, HIRE_DATE = entity.HIRE_DATE, JOB_ID = entity.JOB_ID, SALARY = entity.SALARY, COMMISSION_PCT = entity.COMMISSION_PCT, MANAGER_ID = entity.MANAGER_ID, DEPARTMENT_ID = entity.DEPARTMENT_ID });
	}
	public async Task DeleteByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME_, String lAST_NAME_)
	{
		await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.FIRST_NAME == fIRST_NAME_ && x.LAST_NAME == lAST_NAME_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByDEPARTMENT_ID(Int32? dEPARTMENT_ID_)
	{
		await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.DEPARTMENT_ID == dEPARTMENT_ID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByEMAIL(String eMAIL_)
	{
		await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.EMAIL == eMAIL_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByEMPLOYEE_ID(Int32 eMPLOYEE_ID_)
	{
		await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.EMPLOYEE_ID == eMPLOYEE_ID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByJOB_ID(String jOB_ID_)
	{
		await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.JOB_ID == jOB_ID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByMANAGER_ID(Int32? mANAGER_ID_)
	{
		await _dbContext.XE_HR_EMPLOYEES!
			.Where(x => x.MANAGER_ID == mANAGER_ID_)
			.DeleteFromQueryAsync();
	}
}
