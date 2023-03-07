/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Tynamix.ObjectFiller;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClientTests.HydratedDynamicEntities;
public partial class Northwind_HydratedDynamicEntities  : Northwind_HydratedDynamicEntitiesBase
{
	protected Filler<Northwind_dbo_ProductsAndCategories_OM_Query2> _Northwind_dbo_ProductsAndCategories_OM_Query2_Filler = new Filler<Northwind_dbo_ProductsAndCategories_OM_Query2>();
	protected FillerSetup? _Northwind_dbo_ProductsAndCategories_OM_Query2_FillerSetup;
	public FillerSetup GetNorthwind_dbo_ProductsAndCategories_OM_Query2_FillerSetup(Boolean onlyFillExplicitlyNamedProperties)
	{
		if (_Northwind_dbo_ProductsAndCategories_OM_Query2_FillerSetup != null)
			return _Northwind_dbo_ProductsAndCategories_OM_Query2_FillerSetup;
		_Northwind_dbo_ProductsAndCategories_OM_Query2_FillerSetup = _Northwind_dbo_ProductsAndCategories_OM_Query2_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.CategoryID).Use(() => Convert.ToInt32(1))
		.OnProperty(x => x.CategoryName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Description).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(100)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Picture).Use(() => {
                    var bytes = new Byte[Convert.ToInt32(100)];
                    Random.Shared.NextBytes(bytes);
                    return bytes;
                })
		.Result;
		return _Northwind_dbo_ProductsAndCategories_OM_Query2_FillerSetup;
	}
	public Northwind_dbo_ProductsAndCategories_OM_Query2 GetHydratedDynamicNorthwind_dbo_ProductsAndCategories_OM_Query2(Boolean onlyFillExplicitlyNamedProperties = true)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_ProductsAndCategories_OM_Query2(1, onlyFillExplicitlyNamedProperties).First();
	}
	public IEnumerable<Northwind_dbo_ProductsAndCategories_OM_Query2> GetHydratedDynamicIEnumerableOfNorthwind_dbo_ProductsAndCategories_OM_Query2(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true)
	{
		_Northwind_dbo_ProductsAndCategories_OM_Query2_Filler.Setup(GetNorthwind_dbo_ProductsAndCategories_OM_Query2_FillerSetup(onlyFillExplicitlyNamedProperties));
		var retObjects = _Northwind_dbo_ProductsAndCategories_OM_Query2_Filler.Create(numberToCreate);
		FillInnerTypes(retObjects);
		return retObjects;
	}
	private void FillInnerTypes(IEnumerable<Northwind_dbo_ProductsAndCategories_OM_Query2> entities)
	{
		foreach (var entity in entities)
		{
		}
	}
}
