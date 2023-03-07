/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: N/A")]
[RequireHttps]
public class Northwind_dbo_Customers_Controller : ControllerBase
{
	private readonly INorthwind_dbo_Customers_RequestHandler _requestHandler;
	public Northwind_dbo_Customers_Controller(INorthwind_dbo_Customers_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of Customers table
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Customers/GetAll")]
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of Customers table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Customers/GetByCity")]
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCity(String? city)
	{
		return await _requestHandler.HandleGetByCity(city);
	}
	/// <summary>
	/// Get record of Customers table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Customers/GetByCompanyName")]
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCompanyName(String companyName)
	{
		return await _requestHandler.HandleGetByCompanyName(companyName);
	}
	/// <summary>
	/// Get record of Customers table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Customers/GetByCustomerID")]
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCustomerID(String customerID)
	{
		return await _requestHandler.HandleGetByCustomerID(customerID);
	}
	/// <summary>
	/// Get record of Customers table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Customers/GetByPostalCode")]
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByPostalCode(String? postalCode)
	{
		return await _requestHandler.HandleGetByPostalCode(postalCode);
	}
	/// <summary>
	/// Get record of Customers table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Customers/GetByRegion")]
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByRegion(String? region)
	{
		return await _requestHandler.HandleGetByRegion(region);
	}
	/// <summary>
	/// Create and return record of Customers table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("Northwind_dbo_Customers/Create")]
	public async Task<Northwind_dbo_Customers_IR?> Create([FromBody]Northwind_dbo_Customers_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of Customers table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Customers/UpdateByCity")]
	public async Task UpdateByCity(String? city, [FromBody]Northwind_dbo_Customers_IR input)
	{
		await _requestHandler.HandleUpdateByCity(city, input);
	}
	/// <summary>
	/// Update record of Customers table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Customers/UpdateByCompanyName")]
	public async Task UpdateByCompanyName(String companyName, [FromBody]Northwind_dbo_Customers_IR input)
	{
		await _requestHandler.HandleUpdateByCompanyName(companyName, input);
	}
	/// <summary>
	/// Update record of Customers table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Customers/UpdateByCustomerID")]
	public async Task UpdateByCustomerID(String customerID, [FromBody]Northwind_dbo_Customers_IR input)
	{
		await _requestHandler.HandleUpdateByCustomerID(customerID, input);
	}
	/// <summary>
	/// Update record of Customers table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Customers/UpdateByPostalCode")]
	public async Task UpdateByPostalCode(String? postalCode, [FromBody]Northwind_dbo_Customers_IR input)
	{
		await _requestHandler.HandleUpdateByPostalCode(postalCode, input);
	}
	/// <summary>
	/// Update record of Customers table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Customers/UpdateByRegion")]
	public async Task UpdateByRegion(String? region, [FromBody]Northwind_dbo_Customers_IR input)
	{
		await _requestHandler.HandleUpdateByRegion(region, input);
	}
	/// <summary>
	/// Delete record of Customers table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Customers/DeleteByCity")]
	public async Task DeleteByCity(String? city)
	{
		await _requestHandler.HandleDeleteByCity(city);
	}
	/// <summary>
	/// Delete record of Customers table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Customers/DeleteByCompanyName")]
	public async Task DeleteByCompanyName(String companyName)
	{
		await _requestHandler.HandleDeleteByCompanyName(companyName);
	}
	/// <summary>
	/// Delete record of Customers table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Customers/DeleteByCustomerID")]
	public async Task DeleteByCustomerID(String customerID)
	{
		await _requestHandler.HandleDeleteByCustomerID(customerID);
	}
	/// <summary>
	/// Delete record of Customers table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Customers/DeleteByPostalCode")]
	public async Task DeleteByPostalCode(String? postalCode)
	{
		await _requestHandler.HandleDeleteByPostalCode(postalCode);
	}
	/// <summary>
	/// Delete record of Customers table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Customers/DeleteByRegion")]
	public async Task DeleteByRegion(String? region)
	{
		await _requestHandler.HandleDeleteByRegion(region);
	}
}
