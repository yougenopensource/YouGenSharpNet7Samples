/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_BackEndCoreWCFServer.Services;
[ServiceContract]
public interface IXE_HR_REGIONS_Service
{
	[OperationContract]
	Task<IEnumerable<XE_HR_REGIONS_IR>?> GetAll();
	[OperationContract]
	Task<IEnumerable<XE_HR_REGIONS_IR>?> GetByREGION_ID(String? rEGION_ID_IR);
	[OperationContract]
	Task<XE_HR_REGIONS_IR?> Create(XE_HR_REGIONS_IR input);
	[OperationContract]
	Task UpdateByREGION_ID(String? rEGION_ID_IR, XE_HR_REGIONS_IR input);
	[OperationContract]
	Task DeleteByREGION_ID(String? rEGION_ID_IR);
}
