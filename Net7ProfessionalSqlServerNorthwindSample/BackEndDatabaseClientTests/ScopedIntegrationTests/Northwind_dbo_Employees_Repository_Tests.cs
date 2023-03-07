/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
public class Northwind_dbo_Employees_Repository_Tests : ScopedIntegrationRepositoryTestBase
{
    private Mock<ILogger<Northwind_dbo_Employees_Repository>>? _logger;
	private INorthwind_dbo_Employees_Repository? _repository;
    private Northwind_HydratedStaticEntities? _staticEntities;      
    private Northwind_HydratedDynamicEntities? _dynamicEntities;      
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
        _logger = new Mock<ILogger<Northwind_dbo_Employees_Repository>>();		
        _repository = new Northwind_dbo_Employees_Repository(_logger!.Object, _context!);
        _staticEntities = new Northwind_HydratedStaticEntities();      
        _dynamicEntities = new Northwind_HydratedDynamicEntities();        
    }
	private async Task<Northwind_dbo_Employees?> StaticCreate()
	{
		var staticEntity = _staticEntities!.GetHydratedStaticNorthwind_dbo_Employees();
		return await _repository!.Create(staticEntity);
	}
	private async Task<Northwind_dbo_Employees?> DynamicCreate()
	{
		var dynamicEntity = _dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Employees();
		return await _repository!.Create(dynamicEntity);
	}
	private async Task<IEnumerable<Northwind_dbo_Employees>?> GetAll()
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
	public async Task StaticGetByLastNameTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		var retData = await _repository!.GetByLastName(staticEntity!.LastName);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicGetByLastNameTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		var retData = await _repository!.GetByLastName(dynamicEntity!.LastName);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticGetByEmployeeIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		var retData = await _repository!.GetByEmployeeID(staticEntity!.EmployeeID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicGetByEmployeeIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		var retData = await _repository!.GetByEmployeeID(dynamicEntity!.EmployeeID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticGetByPostalCodeTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		var retData = await _repository!.GetByPostalCode(staticEntity!.PostalCode);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicGetByPostalCodeTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		var retData = await _repository!.GetByPostalCode(dynamicEntity!.PostalCode);
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
	public async Task StaticUpdateByLastNameTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByLastName(staticEntity!.LastName, staticEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicUpdateByLastNameTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByLastName(dynamicEntity!.LastName, dynamicEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticUpdateByEmployeeIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByEmployeeID(staticEntity!.EmployeeID, staticEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicUpdateByEmployeeIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByEmployeeID(dynamicEntity!.EmployeeID, dynamicEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticUpdateByPostalCodeTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByPostalCode(staticEntity!.PostalCode, staticEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicUpdateByPostalCodeTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		// Optionally Modify Values
		await _repository!.UpdateByPostalCode(dynamicEntity!.PostalCode, dynamicEntity);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticDeleteByLastNameTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		await _repository!.DeleteByLastName(staticEntity!.LastName);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicDeleteByLastNameTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		await _repository!.DeleteByLastName(dynamicEntity!.LastName);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticDeleteByEmployeeIDTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		await _repository!.DeleteByEmployeeID(staticEntity!.EmployeeID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicDeleteByEmployeeIDTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		await _repository!.DeleteByEmployeeID(dynamicEntity!.EmployeeID);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task StaticDeleteByPostalCodeTest()
	{
		// Given
		var staticEntity = await StaticCreate();
		// When
		await _repository!.DeleteByPostalCode(staticEntity!.PostalCode);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicDeleteByPostalCodeTest()
	{
		// Given
		var dynamicEntity = await DynamicCreate();
		// When
		await _repository!.DeleteByPostalCode(dynamicEntity!.PostalCode);
		var retData = await GetAll();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
}
