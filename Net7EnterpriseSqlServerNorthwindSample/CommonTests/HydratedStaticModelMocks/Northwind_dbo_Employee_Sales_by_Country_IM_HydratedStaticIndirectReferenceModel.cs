/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
namespace Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
public partial class Northwind_HydratedStaticIndirectReferenceTransformerModels : Northwind_HydratedStaticIndirectReferenceTransformerModelsBase
{
	public Northwind_dbo_Employee_Sales_by_Country_IM_IR GetHydratedStaticNorthwind_dbo_Employee_Sales_by_Country_IM_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Employee_Sales_by_Country_IM_IR();
		retObj.Beginning_Date = DateTime.Parse("5/16/1998 12:00:00 AM");
		retObj.Ending_Date = DateTime.Parse("9/30/2005 12:00:00 AM");
		return retObj;
	}
}
