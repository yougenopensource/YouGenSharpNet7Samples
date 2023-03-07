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
public class Northwind_dbo_Orders_RequestHandler : INorthwind_dbo_Orders_RequestHandler
{
    private readonly ILogger<Northwind_dbo_Orders_RequestHandler> _logger;
    private readonly INorthwind_dbo_Orders_Repository _repository;
    public Northwind_dbo_Orders_RequestHandler(
    ILogger<Northwind_dbo_Orders_RequestHandler> logger
    ,INorthwind_dbo_Orders_Repository repository)
    {
        _logger = logger;
        _repository = repository;
    }
	//Main Handlers
	public async Task<IEnumerable<Northwind_dbo_Orders>?> HandleGetAll()
	{
		var retData = await _repository.GetAll();
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> HandleGetByCustomerID(String? customerID)
	{
		var retData = await _repository.GetByCustomerID(customerID);
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> HandleGetByEmployeeID(Int32? employeeID)
	{
		var retData = await _repository.GetByEmployeeID(employeeID);
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> HandleGetByOrderDate(DateTime? orderDate)
	{
		var retData = await _repository.GetByOrderDate(orderDate);
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> HandleGetByOrderID(Int32 orderID)
	{
		var retData = await _repository.GetByOrderID(orderID);
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> HandleGetByShippedDate(DateTime? shippedDate)
	{
		var retData = await _repository.GetByShippedDate(shippedDate);
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> HandleGetByShipVia(Int32? shipVia)
	{
		var retData = await _repository.GetByShipVia(shipVia);
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Orders>?> HandleGetByShipPostalCode(String? shipPostalCode)
	{
		var retData = await _repository.GetByShipPostalCode(shipPostalCode);
		return retData;
	}
	public async Task<Northwind_dbo_Orders?> HandleCreate(Northwind_dbo_Orders input)
	{
		var results = await _repository.Create(input);
		return results;
	}
	public async Task HandleUpdateByCustomerID(String? customerID, Northwind_dbo_Orders entity)
	{
		await _repository.UpdateByCustomerID(customerID, entity);
	}
	public async Task HandleUpdateByEmployeeID(Int32? employeeID, Northwind_dbo_Orders entity)
	{
		await _repository.UpdateByEmployeeID(employeeID, entity);
	}
	public async Task HandleUpdateByOrderDate(DateTime? orderDate, Northwind_dbo_Orders entity)
	{
		await _repository.UpdateByOrderDate(orderDate, entity);
	}
	public async Task HandleUpdateByOrderID(Int32 orderID, Northwind_dbo_Orders entity)
	{
		await _repository.UpdateByOrderID(orderID, entity);
	}
	public async Task HandleUpdateByShippedDate(DateTime? shippedDate, Northwind_dbo_Orders entity)
	{
		await _repository.UpdateByShippedDate(shippedDate, entity);
	}
	public async Task HandleUpdateByShipVia(Int32? shipVia, Northwind_dbo_Orders entity)
	{
		await _repository.UpdateByShipVia(shipVia, entity);
	}
	public async Task HandleUpdateByShipPostalCode(String? shipPostalCode, Northwind_dbo_Orders entity)
	{
		await _repository.UpdateByShipPostalCode(shipPostalCode, entity);
	}
	public async Task HandleDeleteByCustomerID(String? customerID)
	{
		await _repository.DeleteByCustomerID(customerID);
	}
	public async Task HandleDeleteByEmployeeID(Int32? employeeID)
	{
		await _repository.DeleteByEmployeeID(employeeID);
	}
	public async Task HandleDeleteByOrderDate(DateTime? orderDate)
	{
		await _repository.DeleteByOrderDate(orderDate);
	}
	public async Task HandleDeleteByOrderID(Int32 orderID)
	{
		await _repository.DeleteByOrderID(orderID);
	}
	public async Task HandleDeleteByShippedDate(DateTime? shippedDate)
	{
		await _repository.DeleteByShippedDate(shippedDate);
	}
	public async Task HandleDeleteByShipVia(Int32? shipVia)
	{
		await _repository.DeleteByShipVia(shipVia);
	}
	public async Task HandleDeleteByShipPostalCode(String? shipPostalCode)
	{
		await _repository.DeleteByShipPostalCode(shipPostalCode);
	}
}
