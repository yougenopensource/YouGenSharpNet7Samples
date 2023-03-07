/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202848 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndCommon.RequestHandlers;
public class XE_HR_EMP_DETAILS_VIEW_RequestHandler : IXE_HR_EMP_DETAILS_VIEW_RequestHandler
{
    private readonly ILogger<XE_HR_EMP_DETAILS_VIEW_RequestHandler> _logger;
    private readonly IXE_HR_EMP_DETAILS_VIEW_Repository _repository;
    public XE_HR_EMP_DETAILS_VIEW_RequestHandler(
    ILogger<XE_HR_EMP_DETAILS_VIEW_RequestHandler> logger
    ,IXE_HR_EMP_DETAILS_VIEW_Repository repository)
    {
        _logger = logger;
        _repository = repository;
    }
	//Main Handlers
	public async Task<IEnumerable<XE_HR_EMP_DETAILS_VIEW>?> HandleGetAll()
	{
		var retData = await _repository.GetAll();
		return retData;
	}
}
