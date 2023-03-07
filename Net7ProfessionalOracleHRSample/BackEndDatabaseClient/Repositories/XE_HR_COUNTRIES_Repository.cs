/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
using XE_HR_BackEndDatabaseClient;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClient.Repositories;
public class XE_HR_COUNTRIES_Repository : GenericTableRepository<XE_HR_COUNTRIES>, IXE_HR_COUNTRIES_Repository
{
    private readonly ILogger<XE_HR_COUNTRIES_Repository> _logger;    
    public XE_HR_COUNTRIES_Repository
    (
        ILogger<XE_HR_COUNTRIES_Repository> logger
        ,XE_HR_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<XE_HR_COUNTRIES>?> GetByCOUNTRY_ID(String cOUNTRY_ID_)
	{
		return await _dbContext.XE_HR_COUNTRIES!
			.Where(x => x.COUNTRY_ID == cOUNTRY_ID_)
			.Include(x => x.COUNTR_REG_FK_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByCOUNTRY_ID(String cOUNTRY_ID_, XE_HR_COUNTRIES entity)
	{
		await _dbContext.XE_HR_COUNTRIES!
			.Where(x => x.COUNTRY_ID == cOUNTRY_ID_)
			.UpdateFromQueryAsync(x => new XE_HR_COUNTRIES(){ COUNTRY_NAME = entity.COUNTRY_NAME, REGION_ID = entity.REGION_ID });
	}
	public async Task DeleteByCOUNTRY_ID(String cOUNTRY_ID_)
	{
		await _dbContext.XE_HR_COUNTRIES!
			.Where(x => x.COUNTRY_ID == cOUNTRY_ID_)
			.DeleteFromQueryAsync();
	}
}
