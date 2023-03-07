/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Tynamix.ObjectFiller;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClientTests.HydratedDynamicEntities;
public partial class Northwind_HydratedDynamicEntities  : Northwind_HydratedDynamicEntitiesBase
{
	protected Filler<Northwind_dbo_Products_by_Category> _Northwind_dbo_Products_by_Category_Filler = new Filler<Northwind_dbo_Products_by_Category>();
	protected FillerSetup? _Northwind_dbo_Products_by_Category_FillerSetup;
	public FillerSetup GetNorthwind_dbo_Products_by_Category_FillerSetup(Boolean onlyFillExplicitlyNamedProperties)
	{
		if (_Northwind_dbo_Products_by_Category_FillerSetup != null)
			return _Northwind_dbo_Products_by_Category_FillerSetup;
		_Northwind_dbo_Products_by_Category_FillerSetup = _Northwind_dbo_Products_by_Category_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.CategoryName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ProductName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.QuantityPerUnit).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(20)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.UnitsInStock).Use(() => Convert.ToInt16(Random.Shared.Next(Int16.MinValue, Int16.MaxValue)))
		.OnProperty(x => x.Discontinued).Use(() => (Random.Shared.Next() > (Int32.MaxValue / 2)))
		.Result;
		return _Northwind_dbo_Products_by_Category_FillerSetup;
	}
	public Northwind_dbo_Products_by_Category GetHydratedDynamicNorthwind_dbo_Products_by_Category(Boolean onlyFillExplicitlyNamedProperties = true)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_Products_by_Category(1, onlyFillExplicitlyNamedProperties).First();
	}
	public IEnumerable<Northwind_dbo_Products_by_Category> GetHydratedDynamicIEnumerableOfNorthwind_dbo_Products_by_Category(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true)
	{
		_Northwind_dbo_Products_by_Category_Filler.Setup(GetNorthwind_dbo_Products_by_Category_FillerSetup(onlyFillExplicitlyNamedProperties));
		var retObjects = _Northwind_dbo_Products_by_Category_Filler.Create(numberToCreate);
		return retObjects;
	}
}
