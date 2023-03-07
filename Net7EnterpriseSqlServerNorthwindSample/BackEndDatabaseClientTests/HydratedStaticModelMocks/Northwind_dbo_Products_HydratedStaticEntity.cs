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
	public Northwind_dbo_Products GetHydratedStaticNorthwind_dbo_Products(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Products();
		retObj.ProductID = (fillPrimaryKey ? Convert.ToInt32(1) : 0);
		retObj.ProductName = "Xu11n uswNvV2Zx46oi7AnX6P8Ad8KplUkvimFw5";
		retObj.SupplierID = Convert.ToInt32(1);
		retObj.CategoryID = Convert.ToInt32(1);
		retObj.QuantityPerUnit = "a2Is1Bnw7KkaJx3uyyVc";
		retObj.UnitPrice = (0.9244926726665095M);
		retObj.UnitsInStock = (-2443);
		retObj.UnitsOnOrder = (21415);
		retObj.ReorderLevel = (18478);
		retObj.Discontinued = (true);
		// Foreign key entities
		retObj.FK_Products_Categories_Ref = GetHydratedStaticNorthwind_dbo_Categories();
		retObj.FK_Products_Suppliers_Ref = GetHydratedStaticNorthwind_dbo_Suppliers();
		return retObj;
	}
}
