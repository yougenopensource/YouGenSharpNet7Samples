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
public class XE_HR_LOCATIONS_RequestHandler : IXE_HR_LOCATIONS_RequestHandler
{
    private readonly ILogger<XE_HR_LOCATIONS_RequestHandler> _logger;
    private readonly IXE_HR_LOCATIONS_Repository _repository;
    public XE_HR_LOCATIONS_RequestHandler(
    ILogger<XE_HR_LOCATIONS_RequestHandler> logger
    ,IXE_HR_LOCATIONS_Repository repository)
    {
        _logger = logger;
        _repository = repository;
    }
	//Main Handlers
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> HandleGetAll()
	{
		var retData = await _repository.GetAll();
		return retData;
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> HandleGetByCITY(String cITY)
	{
		var retData = await _repository.GetByCITY(cITY);
		return retData;
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> HandleGetByCOUNTRY_ID(String? cOUNTRY_ID)
	{
		var retData = await _repository.GetByCOUNTRY_ID(cOUNTRY_ID);
		return retData;
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> HandleGetByLOCATION_ID(Int32 lOCATION_ID)
	{
		var retData = await _repository.GetByLOCATION_ID(lOCATION_ID);
		return retData;
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> HandleGetBySTATE_PROVINCE(String? sTATE_PROVINCE)
	{
		var retData = await _repository.GetBySTATE_PROVINCE(sTATE_PROVINCE);
		return retData;
	}
	public async Task<XE_HR_LOCATIONS?> HandleCreate(XE_HR_LOCATIONS input)
	{
		var results = await _repository.Create(input);
		return results;
	}
	public async Task HandleUpdateByCITY(String cITY, XE_HR_LOCATIONS entity)
	{
		await _repository.UpdateByCITY(cITY, entity);
	}
	public async Task HandleUpdateByCOUNTRY_ID(String? cOUNTRY_ID, XE_HR_LOCATIONS entity)
	{
		await _repository.UpdateByCOUNTRY_ID(cOUNTRY_ID, entity);
	}
	public async Task HandleUpdateByLOCATION_ID(Int32 lOCATION_ID, XE_HR_LOCATIONS entity)
	{
		await _repository.UpdateByLOCATION_ID(lOCATION_ID, entity);
	}
	public async Task HandleUpdateBySTATE_PROVINCE(String? sTATE_PROVINCE, XE_HR_LOCATIONS entity)
	{
		await _repository.UpdateBySTATE_PROVINCE(sTATE_PROVINCE, entity);
	}
	public async Task HandleDeleteByCITY(String cITY)
	{
		await _repository.DeleteByCITY(cITY);
	}
	public async Task HandleDeleteByCOUNTRY_ID(String? cOUNTRY_ID)
	{
		await _repository.DeleteByCOUNTRY_ID(cOUNTRY_ID);
	}
	public async Task HandleDeleteByLOCATION_ID(Int32 lOCATION_ID)
	{
		await _repository.DeleteByLOCATION_ID(lOCATION_ID);
	}
	public async Task HandleDeleteBySTATE_PROVINCE(String? sTATE_PROVINCE)
	{
		await _repository.DeleteBySTATE_PROVINCE(sTATE_PROVINCE);
	}
}
