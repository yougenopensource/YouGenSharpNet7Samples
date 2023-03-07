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
using Northwind_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
using Northwind_FrontEndSignalRWebsocketClientTests;
using Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
using Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
namespace Northwind_FrontEndSignalRWebsocketClientTests.ScopedIntegrationTests;
[TestClass()]
public class Northwind_dbo_CustomerCustomerDemo_SignalRWebsocketClient_Tests : SignalRWebsocketClientTestBase
{   
	protected INorthwind_dbo_CustomerCustomerDemo_SignalRWebsocketClient? _signalRWebsocketClient;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override async Task Init()
    {
        await base.Init();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
        _signalRWebsocketClient = new Northwind_dbo_CustomerCustomerDemo_SignalRWebsocketClient(_hubUriBase + "/Northwind_dbo_CustomerCustomerDemo_Hub");
        await _signalRWebsocketClient.InitializeAsync();
    }
    [TestCleanup()]
    public virtual async Task TestCleanup()
    {
        await _signalRWebsocketClient!.DisposeAsync();
    }
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await _signalRWebsocketClient!.GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		var retData = await _signalRWebsocketClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		var retData = await _signalRWebsocketClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCustomerIDAndCustomerTypeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByCustomerIDAndCustomerTypeID(input.CustomerID ?? String.Empty, input.CustomerTypeID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCustomerIDAndCustomerTypeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByCustomerIDAndCustomerTypeID(input.CustomerID ?? String.Empty, input.CustomerTypeID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCustomerIDAndCustomerTypeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerCustomerDemo_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		await _signalRWebsocketClient!.UpdateByCustomerIDAndCustomerTypeID(input.CustomerID ?? String.Empty, input.CustomerTypeID ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCustomerIDAndCustomerTypeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		await _signalRWebsocketClient!.UpdateByCustomerIDAndCustomerTypeID(input.CustomerID ?? String.Empty, input.CustomerTypeID ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerIDAndCustomerTypeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		await _signalRWebsocketClient!.DeleteByCustomerIDAndCustomerTypeID(input.CustomerID ?? String.Empty, input.CustomerTypeID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerIDAndCustomerTypeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		await _signalRWebsocketClient!.DeleteByCustomerIDAndCustomerTypeID(input.CustomerID ?? String.Empty, input.CustomerTypeID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}
