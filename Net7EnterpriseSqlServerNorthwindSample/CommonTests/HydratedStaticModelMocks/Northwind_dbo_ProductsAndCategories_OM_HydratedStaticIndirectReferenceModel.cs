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
	public Northwind_dbo_ProductsAndCategories_OM_IR GetHydratedStaticNorthwind_dbo_ProductsAndCategories_OM_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_ProductsAndCategories_OM_IR();
		retObj.Query1_Results_IR!.ToList().Add(new Northwind_dbo_ProductsAndCategories_OM_Query1_IR());
		retObj.Query1_Results_IR!.First()!.ProductID_IR = _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1));
		retObj.Query1_Results_IR!.First()!.ProductName = "fJfKJSpAyoiemsjrPK NHyDYT8DSXBB8qMfuLIkT";
		retObj.Query1_Results_IR!.First()!.SupplierID_IR = _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1));
		retObj.Query1_Results_IR!.First()!.CategoryID_IR = _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1));
		retObj.Query1_Results_IR!.First()!.QuantityPerUnit = "JIjLursivzOXPWeaSdjD";
		retObj.Query1_Results_IR!.First()!.UnitPrice = (0.928653878718961M);
		retObj.Query1_Results_IR!.First()!.UnitsInStock = (-8961);
		retObj.Query1_Results_IR!.First()!.UnitsOnOrder = (14255);
		retObj.Query1_Results_IR!.First()!.ReorderLevel = (-14335);
		retObj.Query1_Results_IR!.First()!.Discontinued = (true);
		retObj.Query2_Results_IR!.ToList().Add(new Northwind_dbo_ProductsAndCategories_OM_Query2_IR());
		retObj.Query2_Results_IR!.First()!.CategoryID_IR = _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1));
		retObj.Query2_Results_IR!.First()!.CategoryName = "YJ1QQu974vrVnvj";
		retObj.Query2_Results_IR!.First()!.Description = "YrWAXqnHY8LAOSl7jB7e7ivaR6lFP07zf8TnV4hSx3Jvb9tuM 2LBdYwv5rliKcrHZ4b1JcF6K9h8Rn5vOJNEpXLKPETtx3Bvnns";
		retObj.Query2_Results_IR!.First()!.Picture = new Byte[] { 200, 156, 151, 43, 57, 2, 25, 134, 132, 196, 161, 14, 13, 157, 199, 137, 220, 194, 65, 189, 12, 73, 188, 185, 109, 20, 124, 25, 69, 232, 250, 223, 246, 145, 235, 210, 42, 119, 238, 126, 38, 112, 235, 172, 16, 90, 217, 132, 192, 240, 90, 220, 24, 20, 134, 162, 35, 57, 30, 55, 75, 3, 73, 72, 25, 110, 84, 16, 157, 76, 162, 149, 187, 16, 248, 28, 47, 170, 68, 14, 106, 48, 134, 222, 143, 203, 94, 200, 205, 131, 116, 82, 25, 207, 184, 218, 250, 130, 138, 65 };
		return retObj;
	}
}
