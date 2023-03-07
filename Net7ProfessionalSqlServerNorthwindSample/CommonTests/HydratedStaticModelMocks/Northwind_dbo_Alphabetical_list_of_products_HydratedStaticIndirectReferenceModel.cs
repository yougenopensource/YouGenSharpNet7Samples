/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
	public Northwind_dbo_Alphabetical_list_of_products_IR GetHydratedStaticNorthwind_dbo_Alphabetical_list_of_products_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Alphabetical_list_of_products_IR();
		retObj.ProductID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.ProductName = "2ICjqt0TuKC68WOUrDe4I99XziwipcxFnPAKmI8K";
		retObj.SupplierID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1)) : String.Empty);
		retObj.CategoryID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1)) : String.Empty);
		retObj.QuantityPerUnit = "KFgDtJbdpCkWrfQ9bjfK";
		retObj.UnitPrice = (0.8604267508397629M);
		retObj.UnitsInStock = (15090);
		retObj.UnitsOnOrder = (-18281);
		retObj.ReorderLevel = (-5402);
		retObj.Discontinued = (false);
		retObj.CategoryName = "OUnx4DvPM20 Sp3";
		return retObj;
	}
}
