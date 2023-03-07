/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClientTests.HydratedStaticEntities;
public partial class XE_HR_HydratedStaticEntities 
{
	public XE_HR_LOCATIONS GetHydratedStaticXE_HR_LOCATIONS(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_LOCATIONS();
		retObj.LOCATION_ID = (fillPrimaryKey ? Convert.ToInt32(1) : 0);
		retObj.STREET_ADDRESS = "3YHrtsOEsav2DQKYkT4tXofdp31iiSnqJKrQfGfH";
		retObj.POSTAL_CODE = "zyfA8 BeeQ 6";
		retObj.CITY = "VGp2bb ED7dNrrqfMf7YeN1ouLjNNw";
		retObj.STATE_PROVINCE = "4arZZmeklSBDXCcv9GTjSa6FF";
		retObj.COUNTRY_ID = "fx";
		// Foreign key entities
		retObj.LOC_C_ID_FK_Ref = GetHydratedStaticXE_HR_COUNTRIES();
		return retObj;
	}
}
