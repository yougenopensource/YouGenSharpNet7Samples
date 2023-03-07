/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedDynamicNorthwind_dbo_Invoices(fillPrimaryKey = false) {
	let retObj = new Northwind_dbo_Invoices_IR();
	retObj.ShipName = generateString(40);
	retObj.ShipAddress = generateString(60);
	retObj.ShipCity = generateString(15);
	retObj.ShipRegion = generateString(15);
	retObj.ShipPostalCode = generateString(10);
	retObj.ShipCountry = generateString(15);
	retObj.CustomerID = (fillPrimaryKey ? generateString(5) : null);
	retObj.CustomerName = generateString(40);
	retObj.Address = generateString(60);
	retObj.City = generateString(15);
	retObj.Region = generateString(15);
	retObj.PostalCode = generateString(10);
	retObj.Country = generateString(15);
	retObj.Salesperson = generateString(31);
	retObj.OrderID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.OrderDate = generateDateTime();
	retObj.RequiredDate = generateDateTime();
	retObj.ShippedDate = generateDateTime();
	retObj.ShipperName = generateString(40);
	retObj.ProductID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.ProductName = generateString(40);
	retObj.UnitPrice = generateDecimal(19,4);
	retObj.Quantity = generateInt16();
	retObj.Discount = generateFloat();
	retObj.ExtendedPrice = generateDecimal(19,4);
	retObj.Freight = generateDecimal(19,4);
	return retObj;
}
