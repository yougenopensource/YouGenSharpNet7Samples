/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
using XE_HR_FrontEndSignalRWebsocketClientTests;
using XE_HR_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
using XE_HR_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
namespace XE_HR_FrontEndSignalRWebsocketClientTests.ScopedIntegrationTests;
[TestClass()]
public class XE_HR_JOBS_SignalRWebsocketClient_Tests : SignalRWebsocketClientTestBase
{   
	protected IXE_HR_JOBS_SignalRWebsocketClient? _signalRWebsocketClient;
	private XE_HR_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private XE_HR_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override async Task Init()
    {
        await base.Init();
		_dynamicIRModels = new XE_HR_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new XE_HR_HydratedStaticIndirectReferenceTransformerModels();
        _signalRWebsocketClient = new XE_HR_JOBS_SignalRWebsocketClient(_hubUriBase + "/XE_HR_JOBS_Hub");
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
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOBS_IR();
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
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOBS_IR();
		// When
		var retData = await _signalRWebsocketClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByJOB_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOBS_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByJOB_ID(input.JOB_ID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByJOB_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOBS_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByJOB_ID(input.JOB_ID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByJOB_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOBS_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOBS_IR();
		// When
		await _signalRWebsocketClient!.UpdateByJOB_ID(input.JOB_ID ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByJOB_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOBS_IR();
		// When
		await _signalRWebsocketClient!.UpdateByJOB_ID(input.JOB_ID ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByJOB_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_JOBS_IR();
		// When
		await _signalRWebsocketClient!.DeleteByJOB_ID(input.JOB_ID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByJOB_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_JOBS_IR();
		// When
		await _signalRWebsocketClient!.DeleteByJOB_ID(input.JOB_ID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}
