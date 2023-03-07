/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200257 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndCommon.RequestHandlers;
public class Northwind_dbo_CustomerCustomerDemo_RequestHandler : INorthwind_dbo_CustomerCustomerDemo_RequestHandler
{
    private readonly ILogger<Northwind_dbo_CustomerCustomerDemo_RequestHandler> _logger;
    private readonly INorthwind_dbo_CustomerCustomerDemo_Repository _repository;
    public Northwind_dbo_CustomerCustomerDemo_RequestHandler(
    ILogger<Northwind_dbo_CustomerCustomerDemo_RequestHandler> logger
    ,INorthwind_dbo_CustomerCustomerDemo_Repository repository)
    {
        _logger = logger;
        _repository = repository;
    }
	//Main Handlers
	public async Task<IEnumerable<Northwind_dbo_CustomerCustomerDemo>?> HandleGetAll()
	{
		var retData = await _repository.GetAll();
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_CustomerCustomerDemo>?> HandleGetByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID)
	{
		var retData = await _repository.GetByCustomerIDAndCustomerTypeID(customerID, customerTypeID);
		return retData;
	}
	public async Task<Northwind_dbo_CustomerCustomerDemo?> HandleCreate(Northwind_dbo_CustomerCustomerDemo input)
	{
		var results = await _repository.Create(input);
		return results;
	}
	public async Task HandleUpdateByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID, Northwind_dbo_CustomerCustomerDemo entity)
	{
		await _repository.UpdateByCustomerIDAndCustomerTypeID(customerID, customerTypeID, entity);
	}
	public async Task HandleDeleteByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID)
	{
		await _repository.DeleteByCustomerIDAndCustomerTypeID(customerID, customerTypeID);
	}
}
