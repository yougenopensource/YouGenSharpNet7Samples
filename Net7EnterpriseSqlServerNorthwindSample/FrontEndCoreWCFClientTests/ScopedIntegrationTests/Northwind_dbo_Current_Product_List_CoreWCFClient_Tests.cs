/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_FrontEndCoreWCFClient.CoreWCFClients;
using Northwind_FrontEndCoreWCFClientTests;
namespace Northwind_FrontEndCoreWCFClientTests.ScopedIntegrationTests;
[TestClass()]
public class Northwind_dbo_Current_Product_List_WCFClient_Tests : CoreWCFServiceClientTestBase
{    
	protected INorthwind_dbo_Current_Product_List_Service? _serviceClient;    
    protected EndpointAddress? _endpointAddress; 
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
        _endpointAddress = new EndpointAddress(_baseAddress! + "/Northwind_dbo_Current_Product_List_Service");
        _serviceClient = new Northwind_dbo_Current_Product_List_ServiceClient(_binding!, _endpointAddress!);
    }
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await _serviceClient!.GetAllAsync();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
}
