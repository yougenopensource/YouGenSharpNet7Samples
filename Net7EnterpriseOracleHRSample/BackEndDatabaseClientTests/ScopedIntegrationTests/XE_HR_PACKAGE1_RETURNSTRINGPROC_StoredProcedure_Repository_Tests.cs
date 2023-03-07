/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
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
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndDatabaseClientTests.HydratedStaticEntities;
using XE_HR_BackEndDatabaseClientTests.HydratedDynamicEntities;
namespace XE_HR_BackEndDatabaseClientTests.ScopedIntegrationTests;
[TestClass()]
public class XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Repository_Tests : ScopedIntegrationStoredProcedureRepositoryTestBase
{
    private Mock<ILogger<XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Repository>>? _logger;
	private IXE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Repository? _repository;
	private XE_HR_HydratedStaticEntities? _staticEntities;
	private XE_HR_HydratedDynamicEntities? _dynamicEntities;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
        _logger = new Mock<ILogger<XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Repository>>();		
        _repository = new XE_HR_PACKAGE1_RETURNSTRINGPROC_StoredProcedure_Repository(_logger!.Object, _dbConnection!);
		_staticEntities = new XE_HR_HydratedStaticEntities();
		_dynamicEntities = new XE_HR_HydratedDynamicEntities();
    }
	[TestMethod()]
	public async Task StaticCall_XE_HR_PACKAGE1_RETURNSTRINGPROC_Test()
	{
		// Given
		var input = _staticEntities!.GetHydratedStaticXE_HR_PACKAGE1_RETURNSTRINGPROC_IM();
		// When
		var retData = await _repository!.Call_XE_HR_PACKAGE1_RETURNSTRINGPROC(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicCall_XE_HR_PACKAGE1_RETURNSTRINGPROC_Test()
	{
		// Given
		var input = _dynamicEntities!.GetHydratedDynamicXE_HR_PACKAGE1_RETURNSTRINGPROC_IM();
		// When
		var retData = await _repository!.Call_XE_HR_PACKAGE1_RETURNSTRINGPROC(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
}
