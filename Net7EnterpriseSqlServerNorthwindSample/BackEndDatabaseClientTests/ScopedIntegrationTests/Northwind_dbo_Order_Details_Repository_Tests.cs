/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_BackEndDatabaseClientTests.HydratedStaticEntities;
using Northwind_BackEndDatabaseClientTests.HydratedDynamicEntities;
namespace Northwind_BackEndDatabaseClientTests.ScopedIntegrationTests;
[TestClass()]
public class Northwind_dbo_Order_Details_Repository_Tests : ScopedIntegrationRepositoryTestBase
{
    private Mock<ILogger<Northwind_dbo_Order_Details_Repository>>? _logger;
	private INorthwind_dbo_Order_Details_Repository? _repository;
    private Northwind_HydratedStaticEntities? _staticEntities;      
    private Northwind_HydratedDynamicEntities? _dynamicEntities;      
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
        _logger = new Mock<ILogger<Northwind_dbo_Order_Details_Repository>>();		
        _repository = new Northwind_dbo_Order_Details_Repository(_logger!.Object, _context!);
        _staticEntities = new Northwind_HydratedStaticEntities();      
        _dynamicEntities = new Northwind_HydratedDynamicEntities();        
    }
	private async Task<Northwind_dbo_Order_Details?> StaticCreate()
	{
		var staticEntity = _staticEntities!.GetHydratedStaticNorthwind_dbo_Order_Details();
		return await _repository!.Create(staticEntity);
	}
	private async Task<Northwind_dbo_Order_Details?> DynamicCreate()
	{
		var dynamicEntity = _dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Order_Details();
		return await _repository!.Create(dynamicEntity);
	}
	private async Task<IEnumerable<Northwind_dbo_Order_Details>?> GetAll()
	{
		await StaticCreate();
		await DynamicCreate();
		return await _repository!.GetAll();
	}
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticGetByOrderIDAndProductIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		var retData = await _repository!.GetByOrderIDAndProductID(staticEntity!.OrderID, staticEntity!.ProductID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicGetByOrderIDAndProductIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		var retData = await _repository!.GetByOrderIDAndProductID(dynamicEntity!.OrderID, dynamicEntity!.ProductID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticGetByOrderIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		var retData = await _repository!.GetByOrderID(staticEntity!.OrderID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicGetByOrderIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		var retData = await _repository!.GetByOrderID(dynamicEntity!.OrderID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticGetByProductIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		var retData = await _repository!.GetByProductID(staticEntity!.ProductID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicGetByProductIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		var retData = await _repository!.GetByProductID(dynamicEntity!.ProductID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticCreateTest()
	{
		// When
		var staticEntity = await StaticCreate();
		// Then
		Assert.IsTrue(staticEntity != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicCreateTest()
	{
		// When
		var dynamicEntity = await DynamicCreate();
		// Then
		Assert.IsTrue(dynamicEntity != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticUpdateByOrderIDAndProductIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByOrderIDAndProductID(staticEntity!.OrderID, staticEntity!.ProductID, staticEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicUpdateByOrderIDAndProductIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByOrderIDAndProductID(dynamicEntity!.OrderID, dynamicEntity!.ProductID, dynamicEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticUpdateByOrderIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByOrderID(staticEntity!.OrderID, staticEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicUpdateByOrderIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByOrderID(dynamicEntity!.OrderID, dynamicEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticUpdateByProductIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByProductID(staticEntity!.ProductID, staticEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicUpdateByProductIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByProductID(dynamicEntity!.ProductID, dynamicEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticDeleteByOrderIDAndProductIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		await _repository!.DeleteByOrderIDAndProductID(staticEntity!.OrderID, staticEntity!.ProductID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicDeleteByOrderIDAndProductIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		await _repository!.DeleteByOrderIDAndProductID(dynamicEntity!.OrderID, dynamicEntity!.ProductID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticDeleteByOrderIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		await _repository!.DeleteByOrderID(staticEntity!.OrderID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicDeleteByOrderIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		await _repository!.DeleteByOrderID(dynamicEntity!.OrderID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticDeleteByProductIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		await _repository!.DeleteByProductID(staticEntity!.ProductID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicDeleteByProductIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		await _repository!.DeleteByProductID(dynamicEntity!.ProductID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
}
