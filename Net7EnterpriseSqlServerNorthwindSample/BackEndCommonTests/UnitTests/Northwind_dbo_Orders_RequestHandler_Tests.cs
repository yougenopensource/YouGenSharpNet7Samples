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
public class Northwind_dbo_Orders_RequestHandler_UnitTests : RequestHandlerUnitTestBase
{
	private Mock<ILogger<Northwind_dbo_Orders_RequestHandler>>? _logger;
	private Boolean isSecondaryLookup;
	private Northwind_HydratedDynamicEntities? _dynamicEntities;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Mock<INorthwind_dbo_Orders_Repository>? _dynamicRepository;
	private Mock<IIRTransformers>? _dynamicIndirectReferenceTransformers;
	private Northwind_dbo_Orders_IR_FluentValidator_Create? _createValidator;
	private Northwind_dbo_Orders_IR_FluentValidator_Read? _readValidator;
	private Northwind_dbo_Orders_IR_FluentValidator_Update? _updateValidator;
	private Northwind_dbo_Orders_IR_FluentValidator_Delete? _deleteValidator;
	private INorthwind_dbo_Orders_RequestHandler? _dynamicRequestHandler;
	private Northwind_HydratedStaticEntities? _staticEntities;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	private Mock<INorthwind_dbo_Orders_Repository>? _staticRepository;
	private Mock<IIRTransformers>? _staticIndirectReferenceTransformers;
	private INorthwind_dbo_Orders_RequestHandler? _staticRequestHandler;
	[TestInitialize()]
	public override void Init()
    {
        base.Init();
		_logger = new Mock<ILogger<Northwind_dbo_Orders_RequestHandler>>();		
		isSecondaryLookup = false;
		_dynamicEntities = new Northwind_HydratedDynamicEntities();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_dynamicIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<Northwind_dbo_Orders>(), isSecondaryLookup)).Returns(_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR());
		_dynamicIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<Northwind_dbo_Orders_IR>(), isSecondaryLookup)).Returns(_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Orders());
		_createValidator = new Northwind_dbo_Orders_IR_FluentValidator_Create();
		_readValidator = new Northwind_dbo_Orders_IR_FluentValidator_Read();
		_updateValidator = new Northwind_dbo_Orders_IR_FluentValidator_Update();
		_deleteValidator = new Northwind_dbo_Orders_IR_FluentValidator_Delete();
		_dynamicRepository = new Mock<INorthwind_dbo_Orders_Repository>();
		_dynamicRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Orders()}));
		_staticEntities = new Northwind_HydratedStaticEntities();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
		_staticIndirectReferenceTransformers = new Mock<IIRTransformers>();
		_staticIndirectReferenceTransformers!.Setup(x => x.ToIndirectModel(It.IsAny<Northwind_dbo_Orders>(), isSecondaryLookup)).Returns(_staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR());
		_staticIndirectReferenceTransformers!.Setup(x => x.ToEntity(It.IsAny<Northwind_dbo_Orders_IR>(), isSecondaryLookup)).Returns(_staticEntities!.GetHydratedStaticNorthwind_dbo_Orders());
		_staticRepository = new Mock<INorthwind_dbo_Orders_Repository>();
		_staticRepository!.Setup(x => x.GetAll()).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Orders()}));
		_dynamicRepository!.Setup(x => x.GetByCustomerID(It.IsAny<String?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Orders()}));
		_staticRepository!.Setup(x => x.GetByCustomerID(It.IsAny<String?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Orders()}));
		_dynamicRepository!.Setup(x => x.GetByEmployeeID(It.IsAny<Int32?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Orders()}));
		_staticRepository!.Setup(x => x.GetByEmployeeID(It.IsAny<Int32?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Orders()}));
		_dynamicRepository!.Setup(x => x.GetByOrderDate(It.IsAny<DateTime?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Orders()}));
		_staticRepository!.Setup(x => x.GetByOrderDate(It.IsAny<DateTime?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Orders()}));
		_dynamicRepository!.Setup(x => x.GetByOrderID(It.IsAny<Int32>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Orders()}));
		_staticRepository!.Setup(x => x.GetByOrderID(It.IsAny<Int32>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Orders()}));
		_dynamicRepository!.Setup(x => x.GetByShippedDate(It.IsAny<DateTime?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Orders()}));
		_staticRepository!.Setup(x => x.GetByShippedDate(It.IsAny<DateTime?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Orders()}));
		_dynamicRepository!.Setup(x => x.GetByShipVia(It.IsAny<Int32?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Orders()}));
		_staticRepository!.Setup(x => x.GetByShipVia(It.IsAny<Int32?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Orders()}));
		_dynamicRepository!.Setup(x => x.GetByShipPostalCode(It.IsAny<String?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Orders()}));
		_staticRepository!.Setup(x => x.GetByShipPostalCode(It.IsAny<String?>())).Returns(Task.FromResult((IEnumerable<Northwind_dbo_Orders>?)new List<Northwind_dbo_Orders>{_staticEntities!.GetHydratedStaticNorthwind_dbo_Orders()}));
		_dynamicRepository!.Setup(x => x.Create(It.IsAny<Northwind_dbo_Orders>())).Returns(Task.FromResult((Northwind_dbo_Orders?)_dynamicEntities!.GetHydratedDynamicNorthwind_dbo_Orders()));
		_staticRepository!.Setup(x => x.Create(It.IsAny<Northwind_dbo_Orders>())).Returns(Task.FromResult((Northwind_dbo_Orders?)_staticEntities!.GetHydratedStaticNorthwind_dbo_Orders()));
		_dynamicRepository!.Setup(x => x.UpdateByCustomerID(It.IsAny<String?>(), It.IsAny<Northwind_dbo_Orders>()));
		_staticRepository!.Setup(x => x.UpdateByCustomerID(It.IsAny<String?>(), It.IsAny<Northwind_dbo_Orders>()));
		_dynamicRepository!.Setup(x => x.UpdateByEmployeeID(It.IsAny<Int32?>(), It.IsAny<Northwind_dbo_Orders>()));
		_staticRepository!.Setup(x => x.UpdateByEmployeeID(It.IsAny<Int32?>(), It.IsAny<Northwind_dbo_Orders>()));
		_dynamicRepository!.Setup(x => x.UpdateByOrderDate(It.IsAny<DateTime?>(), It.IsAny<Northwind_dbo_Orders>()));
		_staticRepository!.Setup(x => x.UpdateByOrderDate(It.IsAny<DateTime?>(), It.IsAny<Northwind_dbo_Orders>()));
		_dynamicRepository!.Setup(x => x.UpdateByOrderID(It.IsAny<Int32>(), It.IsAny<Northwind_dbo_Orders>()));
		_staticRepository!.Setup(x => x.UpdateByOrderID(It.IsAny<Int32>(), It.IsAny<Northwind_dbo_Orders>()));
		_dynamicRepository!.Setup(x => x.UpdateByShippedDate(It.IsAny<DateTime?>(), It.IsAny<Northwind_dbo_Orders>()));
		_staticRepository!.Setup(x => x.UpdateByShippedDate(It.IsAny<DateTime?>(), It.IsAny<Northwind_dbo_Orders>()));
		_dynamicRepository!.Setup(x => x.UpdateByShipVia(It.IsAny<Int32?>(), It.IsAny<Northwind_dbo_Orders>()));
		_staticRepository!.Setup(x => x.UpdateByShipVia(It.IsAny<Int32?>(), It.IsAny<Northwind_dbo_Orders>()));
		_dynamicRepository!.Setup(x => x.UpdateByShipPostalCode(It.IsAny<String?>(), It.IsAny<Northwind_dbo_Orders>()));
		_staticRepository!.Setup(x => x.UpdateByShipPostalCode(It.IsAny<String?>(), It.IsAny<Northwind_dbo_Orders>()));
		_dynamicRepository!.Setup(x => x.DeleteByCustomerID(It.IsAny<String?>()));
		_staticRepository!.Setup(x => x.DeleteByCustomerID(It.IsAny<String?>()));
		_dynamicRepository!.Setup(x => x.DeleteByEmployeeID(It.IsAny<Int32?>()));
		_staticRepository!.Setup(x => x.DeleteByEmployeeID(It.IsAny<Int32?>()));
		_dynamicRepository!.Setup(x => x.DeleteByOrderDate(It.IsAny<DateTime?>()));
		_staticRepository!.Setup(x => x.DeleteByOrderDate(It.IsAny<DateTime?>()));
		_dynamicRepository!.Setup(x => x.DeleteByOrderID(It.IsAny<Int32>()));
		_staticRepository!.Setup(x => x.DeleteByOrderID(It.IsAny<Int32>()));
		_dynamicRepository!.Setup(x => x.DeleteByShippedDate(It.IsAny<DateTime?>()));
		_staticRepository!.Setup(x => x.DeleteByShippedDate(It.IsAny<DateTime?>()));
		_dynamicRepository!.Setup(x => x.DeleteByShipVia(It.IsAny<Int32?>()));
		_staticRepository!.Setup(x => x.DeleteByShipVia(It.IsAny<Int32?>()));
		_dynamicRepository!.Setup(x => x.DeleteByShipPostalCode(It.IsAny<String?>()));
		_staticRepository!.Setup(x => x.DeleteByShipPostalCode(It.IsAny<String?>()));
		_dynamicRequestHandler = new Northwind_dbo_Orders_RequestHandler(_logger.Object, _encryptionDecryptionService!, _dynamicIndirectReferenceTransformers!.Object, _dynamicRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
		_staticRequestHandler = new Northwind_dbo_Orders_RequestHandler(_logger.Object, _encryptionDecryptionService!, _staticIndirectReferenceTransformers!.Object, _staticRepository!.Object, _createValidator!, _readValidator!, _updateValidator!, _deleteValidator!);
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
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
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
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
	public async Task GetByCustomerIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		var retData = await _dynamicRequestHandler!.HandleGetByCustomerID(input.CustomerID);
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
		var retData = await _staticRequestHandler!.HandleGetByCustomerID(input.CustomerID);
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
		var retData = await _dynamicRequestHandler!.HandleGetByEmployeeID(input.EmployeeID_IR ?? String.Empty);
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
		var retData = await _staticRequestHandler!.HandleGetByEmployeeID(input.EmployeeID_IR ?? String.Empty);
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
		var retData = await _dynamicRequestHandler!.HandleGetByOrderDate(input.OrderDate);
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
		var retData = await _staticRequestHandler!.HandleGetByOrderDate(input.OrderDate);
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
		var retData = await _dynamicRequestHandler!.HandleGetByOrderID(input.OrderID_IR ?? String.Empty);
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
		var retData = await _staticRequestHandler!.HandleGetByOrderID(input.OrderID_IR ?? String.Empty);
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
		var retData = await _dynamicRequestHandler!.HandleGetByShippedDate(input.ShippedDate);
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
		var retData = await _staticRequestHandler!.HandleGetByShippedDate(input.ShippedDate);
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
		var retData = await _dynamicRequestHandler!.HandleGetByShipVia(input.ShipVia_IR ?? String.Empty);
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
		var retData = await _staticRequestHandler!.HandleGetByShipVia(input.ShipVia_IR ?? String.Empty);
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
		var retData = await _dynamicRequestHandler!.HandleGetByShipPostalCode(input.ShipPostalCode);
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
		var retData = await _staticRequestHandler!.HandleGetByShipPostalCode(input.ShipPostalCode);
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
		// When
		await _dynamicRequestHandler!.HandleUpdateByCustomerID(input.CustomerID, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByCustomerIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByCustomerID(input.CustomerID, input);
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
		// When
		await _dynamicRequestHandler!.HandleUpdateByEmployeeID(input.EmployeeID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByEmployeeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByEmployeeID(input.EmployeeID_IR ?? String.Empty, input);
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
		// When
		await _dynamicRequestHandler!.HandleUpdateByOrderDate(input.OrderDate, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByOrderDateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByOrderDate(input.OrderDate, input);
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
		// When
		await _dynamicRequestHandler!.HandleUpdateByOrderID(input.OrderID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByOrderIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByOrderID(input.OrderID_IR ?? String.Empty, input);
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
		// When
		await _dynamicRequestHandler!.HandleUpdateByShippedDate(input.ShippedDate, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByShippedDateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByShippedDate(input.ShippedDate, input);
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
		// When
		await _dynamicRequestHandler!.HandleUpdateByShipVia(input.ShipVia_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByShipViaStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByShipVia(input.ShipVia_IR ?? String.Empty, input);
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
		// When
		await _dynamicRequestHandler!.HandleUpdateByShipPostalCode(input.ShipPostalCode, input2);
		// Then
		// TODO: Add test cases
	}
		// When
	[TestMethod()]
	public async Task UpdateByShipPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleUpdateByShipPostalCode(input.ShipPostalCode, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByCustomerID(input.CustomerID);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByCustomerID(input.CustomerID);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEmployeeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByEmployeeID(input.EmployeeID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEmployeeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByEmployeeID(input.EmployeeID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderDateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByOrderDate(input.OrderDate);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderDateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByOrderDate(input.OrderDate);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByShippedDateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByShippedDate(input.ShippedDate);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByShippedDateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByShippedDate(input.ShippedDate);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByShipViaDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByShipVia(input.ShipVia_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByShipViaStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByShipVia(input.ShipVia_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByShipPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Orders_IR();
		// When
		await _dynamicRequestHandler!.HandleDeleteByShipPostalCode(input.ShipPostalCode);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByShipPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Orders_IR();
		// When
		await _staticRequestHandler!.HandleDeleteByShipPostalCode(input.ShipPostalCode);
		// Then
		// TODO: Add test cases
	}
}
