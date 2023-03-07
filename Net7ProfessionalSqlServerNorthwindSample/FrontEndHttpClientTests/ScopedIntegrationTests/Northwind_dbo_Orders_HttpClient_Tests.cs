/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_FrontEndHttpClient.HttpClients;
using Northwind_FrontEndHttpClientTests;
using Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
using Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
namespace Northwind_FrontEndHttpClientTests.ScopedIntegrationTests;
[TestClass()]
public class Northwind_dbo_Orders_HttpClient_Tests : HttpClientTestBase
{
	protected INorthwind_dbo_Orders_HttpClient? _specificHttpClient;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
        _specificHttpClient = new Northwind_dbo_Orders_HttpClient(_httpClient!);
    }
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await _specificHttpClient!.GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCustomerIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByCustomerID(input.CustomerID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCustomerIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByCustomerID(input.CustomerID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByEmployeeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByEmployeeID(input.EmployeeID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByEmployeeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByEmployeeID(input.EmployeeID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByOrderDateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByOrderDate(input.OrderDate);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByOrderDateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByOrderDate(input.OrderDate);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByOrderIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByOrderIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByShippedDateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByShippedDate(input.ShippedDate);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByShippedDateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByShippedDate(input.ShippedDate);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByShipViaDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByShipVia(input.ShipVia_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByShipViaStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByShipVia(input.ShipVia_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByShipPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByShipPostalCode(input.ShipPostalCode);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByShipPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		var retData = await _specificHttpClient!.GetByShipPostalCode(input.ShipPostalCode);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCustomerIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByCustomerID(input.CustomerID, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCustomerIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByCustomerID(input.CustomerID, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByEmployeeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByEmployeeID(input.EmployeeID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByEmployeeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByEmployeeID(input.EmployeeID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByOrderDateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByOrderDate(input.OrderDate, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByOrderDateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByOrderDate(input.OrderDate, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByOrderIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByOrderID(input.OrderID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByOrderIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByOrderID(input.OrderID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByShippedDateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByShippedDate(input.ShippedDate, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByShippedDateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByShippedDate(input.ShippedDate, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByShipViaDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByShipVia(input.ShipVia_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByShipViaStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByShipVia(input.ShipVia_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByShipPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByShipPostalCode(input.ShipPostalCode, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByShipPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.UpdateByShipPostalCode(input.ShipPostalCode, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByCustomerID(input.CustomerID);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByCustomerID(input.CustomerID);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEmployeeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByEmployeeID(input.EmployeeID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEmployeeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByEmployeeID(input.EmployeeID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderDateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByOrderDate(input.OrderDate);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderDateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByOrderDate(input.OrderDate);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByShippedDateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByShippedDate(input.ShippedDate);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByShippedDateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByShippedDate(input.ShippedDate);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByShipViaDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByShipVia(input.ShipVia_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByShipViaStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByShipVia(input.ShipVia_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByShipPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByShipPostalCode(input.ShipPostalCode);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByShipPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _specificHttpClient!.DeleteByShipPostalCode(input.ShipPostalCode);
		// Then
		// TODO: Add test cases
	}
}
