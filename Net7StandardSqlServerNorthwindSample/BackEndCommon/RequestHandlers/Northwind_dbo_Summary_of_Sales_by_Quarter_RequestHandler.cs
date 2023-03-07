/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200434 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndCommon.RequestHandlers;
public class Northwind_dbo_Summary_of_Sales_by_Quarter_RequestHandler : INorthwind_dbo_Summary_of_Sales_by_Quarter_RequestHandler
{
    private readonly ILogger<Northwind_dbo_Summary_of_Sales_by_Quarter_RequestHandler> _logger;
    private readonly INorthwind_dbo_Summary_of_Sales_by_Quarter_Repository _repository;
    public Northwind_dbo_Summary_of_Sales_by_Quarter_RequestHandler(
    ILogger<Northwind_dbo_Summary_of_Sales_by_Quarter_RequestHandler> logger
    ,INorthwind_dbo_Summary_of_Sales_by_Quarter_Repository repository)
    {
        _logger = logger;
        _repository = repository;
    }
	//Main Handlers
	public async Task<IEnumerable<Northwind_dbo_Summary_of_Sales_by_Quarter>?> HandleGetAll()
	{
		var retData = await _repository.GetAll();
		return retData;
	}
}
