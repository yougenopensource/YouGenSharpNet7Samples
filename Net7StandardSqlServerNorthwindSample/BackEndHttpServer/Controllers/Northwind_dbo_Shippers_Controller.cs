/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200434 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: N/A")]
[RequireHttps]
public class Northwind_dbo_Shippers_Controller : ControllerBase
{
	private readonly INorthwind_dbo_Shippers_RequestHandler _requestHandler;
	public Northwind_dbo_Shippers_Controller(INorthwind_dbo_Shippers_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of Shippers table
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Shippers/GetAll")]
	public async Task<IEnumerable<Northwind_dbo_Shippers>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of Shippers table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Shippers/GetByShipperID")]
	public async Task<IEnumerable<Northwind_dbo_Shippers>?> GetByShipperID(Int32 shipperID)
	{
		return await _requestHandler.HandleGetByShipperID(shipperID);
	}
	/// <summary>
	/// Create and return record of Shippers table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("Northwind_dbo_Shippers/Create")]
	public async Task<Northwind_dbo_Shippers?> Create([FromBody]Northwind_dbo_Shippers input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of Shippers table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Shippers/UpdateByShipperID")]
	public async Task UpdateByShipperID(Int32 shipperID, [FromBody]Northwind_dbo_Shippers input)
	{
		await _requestHandler.HandleUpdateByShipperID(shipperID, input);
	}
	/// <summary>
	/// Delete record of Shippers table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Shippers/DeleteByShipperID")]
	public async Task DeleteByShipperID(Int32 shipperID)
	{
		await _requestHandler.HandleDeleteByShipperID(shipperID);
	}
}
