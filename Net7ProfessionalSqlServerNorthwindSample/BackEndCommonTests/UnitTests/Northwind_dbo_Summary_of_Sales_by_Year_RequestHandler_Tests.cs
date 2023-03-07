/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
public class Northwind_dbo_Summary_of_Sales_by_Year_RequestHandler_UnitTests : RequestHandlerUnitTestBase
{
	private Mock<ILogger<Northwind_dbo_Summary_of_Sales_by_Year_RequestHandler>>? _logger;
	private Northwind_HydratedDynamicEntities? _dynamicEntities;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Mock<INorthwind_dbo_Summary_of_Sales_by_Year_Repository>? _dynamicRepository;
	private Mock<IIRTransformers>? _dynamicIndirectReferenceTransformers;
	private Northwind_dbo_Summary_of_Sales_by_Year_IR_FluentValidator? _readValidator;
	private INorthwind_dbo_Summary_of_Sales_by_Year_RequestHandler? _dynamicRequestHandler;
	private Northwind_HydratedStaticEntities? _staticEntities;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	private Mock<INorthwind_dbo_Summary_of_Sales_by_Year_Repository>? _staticRepository;
	private Mock<IIRTransformers>? _staticIndirectReferenceTransformers;
	private INorthwind_dbo_Summary_of_Sales_by_Year_RequestHandler? _staticRequestHandler;
	[TestInitialize()]
	public override void Init()
    {
        base.Init();
		_logger = new Mock<ILogger<Northwind_dbo_Summary_of_Sales_by_Year_RequestHandler>>();		
		_dynamicEntities = new Northwind_HydratedDynamicEntities();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_dynamicIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<Northwind_dbo_Summary_of_Sales_by_Year>())).Returns(_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Summary_of_Sales_by_Year_IR());
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<Northwind_dbo_Summary_of_Sales_by_Year_IR>())).Returns(_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Summary_of_Sales_by_Year());
		_readValidator = new Northwind_dbo_Summary_of_Sales_by_Year_IR_FluentValidator();
		_dynamicRepository = new Mock<INorthwind_dbo_Summary_of_Sales_by_Year_Repository>();
		_dynamicRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Summary_of_Sales_by_Year>?)new List<Northwind_dbo_Summary_of_Sales_by_Year>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Summary_of_Sales_by_Year()}));
		_staticEntities = new Northwind_HydratedStaticEntities();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
		_staticIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_staticIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<Northwind_dbo_Summary_of_Sales_by_Year>())).Returns(_staticIRModels!.GetHydratedStaticNorthwind_dbo_Summary_of_Sales_by_Year_IR());
		_staticIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<Northwind_dbo_Summary_of_Sales_by_Year_IR>())).Returns(_staticEntities!.GetHydratedStaticNorthwind_dbo_Summary_of_Sales_by_Year());
		_staticRepository = new Mock<INorthwind_dbo_Summary_of_Sales_by_Year_Repository>();
		_staticRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Summary_of_Sales_by_Year>?)new List<Northwind_dbo_Summary_of_Sales_by_Year>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Summary_of_Sales_by_Year()}));
		_dynamicRequestHandler = new Northwind_dbo_Summary_of_Sales_by_Year_RequestHandler(_logger.Object, _encryptionDecryptionService!, _dynamicIndirectReferenceTransformers!.Object, _dynamicRepository!.Object, _readValidator!);
		_staticRequestHandler = new Northwind_dbo_Summary_of_Sales_by_Year_RequestHandler(_logger.Object, _encryptionDecryptionService!, _staticIndirectReferenceTransformers!.Object, _staticRepository!.Object, _readValidator!);
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
	public async Task GetAllStaticTest()
	{
		// When
		var retData = await _staticRequestHandler!.HandleGetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
}
