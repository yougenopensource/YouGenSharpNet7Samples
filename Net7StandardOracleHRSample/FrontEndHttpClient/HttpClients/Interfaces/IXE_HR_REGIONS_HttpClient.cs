/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202848 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public interface IXE_HR_REGIONS_HttpClient
{
	Task<IEnumerable<XE_HR_REGIONS>?> GetAll();
	Task<IEnumerable<XE_HR_REGIONS>?> GetByREGION_ID(Int32 rEGION_ID);
	Task<XE_HR_REGIONS?> Create(XE_HR_REGIONS input);
	Task UpdateByREGION_ID(Int32 rEGION_ID, XE_HR_REGIONS input);
	Task DeleteByREGION_ID(Int32 rEGION_ID);
}
