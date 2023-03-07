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
using Tynamix.ObjectFiller;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
namespace Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
public partial class Northwind_HydratedDynamicIndirectReferenceTransformerModels : Northwind_HydratedDynamicIndirectReferenceTransformerModelsBase
{
	protected Filler<Northwind_dbo_Sales_by_Category_IR> _Northwind_dbo_Sales_by_Category_IR_Filler = new Filler<Northwind_dbo_Sales_by_Category_IR>();
	protected FillerSetup? _Northwind_dbo_Sales_by_Category_IR_FillerSetup;
	public FillerSetup GetNorthwind_dbo_Sales_by_Category_IR_FillerSetup(Boolean onlyFillExplicitlyNamedProperties)
	{
		if (_Northwind_dbo_Sales_by_Category_IR_FillerSetup != null)
			return _Northwind_dbo_Sales_by_Category_IR_FillerSetup;
		_Northwind_dbo_Sales_by_Category_IR_FillerSetup = _Northwind_dbo_Sales_by_Category_IR_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.CategoryID_IR).Use(() => _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)))
		.OnProperty(x => x.CategoryName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ProductName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ProductSales).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.Result;
		return _Northwind_dbo_Sales_by_Category_IR_FillerSetup;
	}
	public Northwind_dbo_Sales_by_Category_IR GetHydratedDynamicNorthwind_dbo_Sales_by_Category_IR(Boolean onlyFillExplicitlyNamedProperties = true)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_Sales_by_Category_IR(1, onlyFillExplicitlyNamedProperties).First();
	}
	public IEnumerable<Northwind_dbo_Sales_by_Category_IR> GetHydratedDynamicIEnumerableOfNorthwind_dbo_Sales_by_Category_IR(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true)
	{
		_Northwind_dbo_Sales_by_Category_IR_Filler.Setup(GetNorthwind_dbo_Sales_by_Category_IR_FillerSetup(onlyFillExplicitlyNamedProperties));
		var retObjects =  _Northwind_dbo_Sales_by_Category_IR_Filler.Create(numberToCreate);
		return retObjects;
	}
}
