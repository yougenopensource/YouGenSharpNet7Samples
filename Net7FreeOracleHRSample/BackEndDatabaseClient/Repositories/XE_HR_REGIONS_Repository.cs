/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202757 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
using XE_HR_BackEndDatabaseClient;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClient.Repositories;
public class XE_HR_REGIONS_Repository : GenericTableRepository<XE_HR_REGIONS>, IXE_HR_REGIONS_Repository
{
    private readonly ILogger<XE_HR_REGIONS_Repository> _logger;    
    public XE_HR_REGIONS_Repository
    (
        ILogger<XE_HR_REGIONS_Repository> logger
        ,XE_HR_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<XE_HR_REGIONS>?> GetByREGION_ID(Int32 rEGION_ID_)
	{
		return await _dbContext.XE_HR_REGIONS!
			.Where(x => x.REGION_ID == rEGION_ID_)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByREGION_ID(Int32 rEGION_ID_, XE_HR_REGIONS entity)
	{
		await _dbContext.XE_HR_REGIONS!
			.Where(x => x.REGION_ID == rEGION_ID_)
			.UpdateFromQueryAsync(x => new XE_HR_REGIONS(){ REGION_NAME = entity.REGION_NAME });
	}
	public async Task DeleteByREGION_ID(Int32 rEGION_ID_)
	{
		await _dbContext.XE_HR_REGIONS!
			.Where(x => x.REGION_ID == rEGION_ID_)
			.DeleteFromQueryAsync();
	}
}
