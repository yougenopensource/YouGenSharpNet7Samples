/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndCoreWCFServer.Services;
public partial class Northwind_dbo_Customers_Service : INorthwind_dbo_Customers_Service
{
	private readonly INorthwind_dbo_Customers_RequestHandler _requestHandler;
	public Northwind_dbo_Customers_Service(INorthwind_dbo_Customers_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCity(String? city)
	{
		return await _requestHandler.HandleGetByCity(city);
	}
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCompanyName(String companyName)
	{
		return await _requestHandler.HandleGetByCompanyName(companyName);
	}
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCustomerID(String customerID)
	{
		return await _requestHandler.HandleGetByCustomerID(customerID);
	}
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByPostalCode(String? postalCode)
	{
		return await _requestHandler.HandleGetByPostalCode(postalCode);
	}
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByRegion(String? region)
	{
		return await _requestHandler.HandleGetByRegion(region);
	}
	public async Task<Northwind_dbo_Customers_IR?> Create(Northwind_dbo_Customers_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	public async Task UpdateByCity(String? city, Northwind_dbo_Customers_IR input)
	{
		await _requestHandler.HandleUpdateByCity(city, input);
	}
	public async Task UpdateByCompanyName(String companyName, Northwind_dbo_Customers_IR input)
	{
		await _requestHandler.HandleUpdateByCompanyName(companyName, input);
	}
	public async Task UpdateByCustomerID(String customerID, Northwind_dbo_Customers_IR input)
	{
		await _requestHandler.HandleUpdateByCustomerID(customerID, input);
	}
	public async Task UpdateByPostalCode(String? postalCode, Northwind_dbo_Customers_IR input)
	{
		await _requestHandler.HandleUpdateByPostalCode(postalCode, input);
	}
	public async Task UpdateByRegion(String? region, Northwind_dbo_Customers_IR input)
	{
		await _requestHandler.HandleUpdateByRegion(region, input);
	}
	public async Task DeleteByCity(String? city)
	{
		await _requestHandler.HandleDeleteByCity(city);
	}
	public async Task DeleteByCompanyName(String companyName)
	{
		await _requestHandler.HandleDeleteByCompanyName(companyName);
	}
	public async Task DeleteByCustomerID(String customerID)
	{
		await _requestHandler.HandleDeleteByCustomerID(customerID);
	}
	public async Task DeleteByPostalCode(String? postalCode)
	{
		await _requestHandler.HandleDeleteByPostalCode(postalCode);
	}
	public async Task DeleteByRegion(String? region)
	{
		await _requestHandler.HandleDeleteByRegion(region);
	}
}
