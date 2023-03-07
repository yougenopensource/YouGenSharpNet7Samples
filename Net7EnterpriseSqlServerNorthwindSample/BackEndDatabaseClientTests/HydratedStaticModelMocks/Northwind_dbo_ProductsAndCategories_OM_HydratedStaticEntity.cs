/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClientTests.HydratedStaticEntities;
public partial class Northwind_HydratedStaticEntities 
{
	public Northwind_dbo_ProductsAndCategories_OM GetHydratedStaticNorthwind_dbo_ProductsAndCategories_OM(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_ProductsAndCategories_OM();
		retObj.Query1_Results!.ToList().Add(new Northwind_dbo_ProductsAndCategories_OM_Query1());
		retObj.Query1_Results!.First()!.ProductID = Convert.ToInt32(1);
		retObj.Query1_Results!.First()!.ProductName = "4E3y0VY7YhGOAAvHnv9BNx3Vm0LsS4AO4ia4aaGo";
		retObj.Query1_Results!.First()!.SupplierID = Convert.ToInt32(1);
		retObj.Query1_Results!.First()!.CategoryID = Convert.ToInt32(1);
		retObj.Query1_Results!.First()!.QuantityPerUnit = "9DnxBdGqBBc7M3L e0Ce";
		retObj.Query1_Results!.First()!.UnitPrice = (0.1880123755478751M);
		retObj.Query1_Results!.First()!.UnitsInStock = (-4597);
		retObj.Query1_Results!.First()!.UnitsOnOrder = (21231);
		retObj.Query1_Results!.First()!.ReorderLevel = (32414);
		retObj.Query1_Results!.First()!.Discontinued = (false);
		retObj.Query2_Results!.ToList().Add(new Northwind_dbo_ProductsAndCategories_OM_Query2());
		retObj.Query2_Results!.First()!.CategoryID = Convert.ToInt32(1);
		retObj.Query2_Results!.First()!.CategoryName = "nDu3ckXPsCyBP3t";
		retObj.Query2_Results!.First()!.Description = "kO9lpXyYwvlMR9dtWciE8 Pf4EazaLIyhi40r0yxrP knNfPRJlP9SE4b1cfgLa9WcFcaqZ4dgsq7WPqzJ6mOSz 0dtjCurrBjD4";
		retObj.Query2_Results!.First()!.Picture = new Byte[] { 84, 42, 164, 217, 82, 80, 201, 31, 147, 201, 194, 76, 70, 249, 79, 136, 41, 45, 248, 34, 166, 161, 175, 110, 49, 47, 74, 89, 60, 232, 192, 219, 107, 19, 154, 35, 31, 55, 202, 132, 5, 74, 162, 162, 96, 107, 233, 215, 65, 195, 137, 180, 145, 242, 105, 31, 182, 129, 195, 169, 224, 113, 190, 139, 19, 120, 184, 132, 120, 174, 191, 252, 247, 92, 91, 233, 253, 223, 220, 242, 174, 10, 232, 221, 152, 90, 154, 159, 190, 253, 35, 216, 3, 36, 187, 85, 186, 78, 100, 84 };
		return retObj;
	}
}
