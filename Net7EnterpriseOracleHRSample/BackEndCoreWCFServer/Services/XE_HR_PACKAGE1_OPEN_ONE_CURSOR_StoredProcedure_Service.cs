/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_BackEndCommon.RequestHandlers;
namespace XE_HR_BackEndCoreWCFServer.Services;
public partial class XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Service : IXE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Service
{
	private readonly IXE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_RequestHandler _requestHandler;
	public XE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_Service(IXE_HR_PACKAGE1_OPEN_ONE_CURSOR_StoredProcedure_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_IR?> Call_XE_HR_PACKAGE1_OPEN_ONE_CURSOR(XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR input)
	{
		return await _requestHandler.HandleCall_XE_HR_PACKAGE1_OPEN_ONE_CURSOR(input);
	}
}
