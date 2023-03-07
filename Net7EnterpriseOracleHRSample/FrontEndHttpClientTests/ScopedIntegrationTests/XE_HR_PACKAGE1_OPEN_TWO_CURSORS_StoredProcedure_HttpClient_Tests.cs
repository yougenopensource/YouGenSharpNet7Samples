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
using XE_HR_FrontEndHttpClient.HttpClients;
using XE_HR_FrontEndHttpClientTests;
using XE_HR_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
using XE_HR_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
namespace XE_HR_FrontEndHttpClientTests.ScopedIntegrationTests;
[TestClass()]
public class XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_HttpClient_Tests : HttpClientTestBase
{
	protected IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_HttpClient? _specificHttpClient;
	private XE_HR_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private XE_HR_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
		_dynamicIRModels = new XE_HR_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new XE_HR_HydratedStaticIndirectReferenceTransformerModels();
        _specificHttpClient = new XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_HttpClient(_httpClient!);
    }
	[TestMethod()]
	public async Task StaticCall_XE_HR_PACKAGE1_OPEN_TWO_CURSORS_Test()
	{
		// When
		var retData = await _specificHttpClient!.Call_XE_HR_PACKAGE1_OPEN_TWO_CURSORS();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DynamicCall_XE_HR_PACKAGE1_OPEN_TWO_CURSORS_Test()
	{
		// When
		var retData = await _specificHttpClient!.Call_XE_HR_PACKAGE1_OPEN_TWO_CURSORS();
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
}
