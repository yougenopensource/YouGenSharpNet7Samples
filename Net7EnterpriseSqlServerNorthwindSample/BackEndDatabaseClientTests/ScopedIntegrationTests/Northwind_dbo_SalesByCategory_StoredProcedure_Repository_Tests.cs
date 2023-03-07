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
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndDatabaseClientTests.HydratedStaticEntities;
using Northwind_BackEndDatabaseClientTests.HydratedDynamicEntities;
namespace Northwind_BackEndDatabaseClientTests.ScopedIntegrationTests;
[TestClass()]
public class Northwind_dbo_SalesByCategory_StoredProcedure_Repository_Tests : ScopedIntegrationStoredProcedureRepositoryTestBase
{
    private Mock<ILogger<Northwind_dbo_SalesByCategory_StoredProcedure_Repository>>? _logger;
	private INorthwind_dbo_SalesByCategory_StoredProcedure_Repository? _repository;
	private Northwind_HydratedStaticEntities? _staticEntities;
	private Northwind_HydratedDynamicEntities? _dynamicEntities;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
        _logger = new Mock<ILogger<Northwind_dbo_SalesByCategory_StoredProcedure_Repository>>();		
        _repository = new Northwind_dbo_SalesByCategory_StoredProcedure_Repository(_logger!.Object, _dbConnection!);
		_staticEntities = new Northwind_HydratedStaticEntities();
		_dynamicEntities = new Northwind_HydratedDynamicEntities();
    }
	[TestMethod()]
	public async Task StaticCall_Northwind_dbo_SalesByCategory_Test()
	{
		// Given
		var input = _staticEntities!.GetHydratedStaticNorthwind_dbo_SalesByCategory_IM();
		// When
		var retData = await _repository!.Call_Northwind_dbo_SalesByCategory(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicCall_Northwind_dbo_SalesByCategory_Test()
	{
		// Given
		var input = _dynamicEntities!.GetHydratedDynamicNorthwind_dbo_SalesByCategory_IM();
		// When
		var retData = await _repository!.Call_Northwind_dbo_SalesByCategory(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
}
