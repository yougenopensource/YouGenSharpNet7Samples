/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_Common.Validators;
using Northwind_BackEndCommon.IndirectReferenceTransformers;
using Northwind_BackEndCommon.RequestHandlers;
using Northwind_BackEndDatabaseClientTests.HydratedStaticEntities;
using Northwind_BackEndDatabaseClientTests.HydratedDynamicEntities;
using Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
using Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
namespace Northwind_BackEndCommonTests.RequestHandlerUnitTests;
[TestClass()]
public class Northwind_dbo_Region_RequestHandler_UnitTests : RequestHandlerUnitTestBase
{
	private Mock<ILogger<Northwind_dbo_Region_RequestHandler>>? _logger;
	private Boolean isSecondaryLookup;
	private Northwind_HydratedDynamicEntities? _dynamicEntities;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Mock<INorthwind_dbo_Region_Repository>? _dynamicRepository;
	private Mock<IIRTransformers>? _dynamicIndirectReferenceTransformers;
	private Northwind_dbo_Region_IR_FluentValidator_Create? _createValidator;
	private Northwind_dbo_Region_IR_FluentValidator_Read? _readValidator;
	private Northwind_dbo_Region_IR_FluentValidator_Update? _updateValidator;
	private Northwind_dbo_Region_IR_FluentValidator_Delete? _deleteValidator;
	private INorthwind_dbo_Region_RequestHandler? _dynamicRequestHandler;
	private Northwind_HydratedStaticEntities? _staticEntities;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	private Mock<INorthwind_dbo_Region_Repository>? _staticRepository;
	private Mock<IIRTransformers>? _staticIndirectReferenceTransformers;
	private INorthwind_dbo_Region_RequestHandler? _staticRequestHandler;
	[TestInitialize()]
	public override void Init()
    {
        base.Init();
		_logger = new Mock<ILogger<Northwind_dbo_Region_RequestHandler>>();		
		isSecondaryLookup = false;
		_dynamicEntities = new Northwind_HydratedDynamicEntities();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_dynamicIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<Northwind_dbo_Region>(), isSecondaryLookup)).Returns(_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Region_IR());
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<Northwind_dbo_Region_IR>(), isSecondaryLookup)).Returns(_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Region());
		_createValidator = new Northwind_dbo_Region_IR_FluentValidator_Create();
		_readValidator = new Northwind_dbo_Region_IR_FluentValidator_Read();
		_updateValidator = new Northwind_dbo_Region_IR_FluentValidator_Update();
		_deleteValidator = new Northwind_dbo_Region_IR_FluentValidator_Delete();
		_dynamicRepository = new Mock<INorthwind_dbo_Region_Repository>();
		_dynamicRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Region>?)new List<Northwind_dbo_Region>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Region()}));
		_staticEntities = new Northwind_HydratedStaticEntities();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
		_staticIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_staticIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<Northwind_dbo_Region>(), isSecondaryLookup)).Returns(_staticIRModels!.GetHydratedStaticNorthwind_dbo_Region_IR());
		_staticIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<Northwind_dbo_Region_IR>(), isSecondaryLookup)).Returns(_staticEntities!.GetHydratedStaticNorthwind_dbo_Region());
		_staticRepository = new Mock<INorthwind_dbo_Region_Repository>();
		_staticRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Region>?)new List<Northwind_dbo_Region>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Region()}));
		_dynamicRepository!.Setup(x => x.GetByRegionID(It.IsAny<Int32>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Region>?)new List<Northwind_dbo_Region>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Region()}));
		_staticRepository!.Setup(x => x.GetByRegionID(It.IsAny<Int32>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Region>?)new List<Northwind_dbo_Region>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Region()}));
		_dynamicRepository!.Setup(x => x.Create(It.IsAny<Northwind_dbo_Region>())).Returns(Task.FromResult((Northwind_dbo_Region?)_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Region()));
		_staticRepository!.Setup(x => x.Create(It.IsAny<Northwind_dbo_Region>())).Returns(Task.FromResult((Northwind_dbo_Region?)_staticEntities!.GetHydratedStaticNorthwind_dbo_Region()));
		_dynamicRepository!.Setup(x => x.UpdateByRegionID(It.IsAny<Int32>(), It.IsAny<Northwind_dbo_Region>()));
		_staticRepository!.Setup(x => x.UpdateByRegionID(It.IsAny<Int32>(), It.IsAny<Northwind_dbo_Region>()));
		_dynamicRepository!.Setup(x => x.DeleteByRegionID(It.IsAny<Int32>()));
		_staticRepository!.Setup(x => x.DeleteByRegionID(It.IsAny<Int32>()));
		_dynamicRequestHandler = new Northwind_dbo_Region_RequestHandler(_logger.Object, _encryptionDecryptionService!, _dynamicIndirectReferenceTransformers!.Object, _dynamicRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
		_staticRequestHandler = new Northwind_dbo_Region_RequestHandler(_logger.Object, _encryptionDecryptionService!, _staticIndirectReferenceTransformers!.Object, _staticRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Region_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleCreate(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetAllDynamicTest()
	{
		// When
		var retData = await _dynamicRequestHandler!.HandleGetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Region_IR();
		// When
		var retData = await _staticRequestHandler!.HandleCreate(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetAllStaticTest()
	{
		// When
		var retData = await _staticRequestHandler!.HandleGetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByRegionIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Region_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByRegionID(input.RegionID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByRegionIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Region_IR();
		// When
		var retData = await _staticRequestHandler!.HandleGetByRegionID(input.RegionID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByRegionIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Region_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Region_IR();
		// When
		// When
		await _dynamicRequestHandler!.HandleUpdateByRegionID(input.RegionID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByRegionIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Region_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByRegionID(input.RegionID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByRegionIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Region_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByRegionID(input.RegionID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByRegionIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Region_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByRegionID(input.RegionID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}
