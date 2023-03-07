/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
class Northwind_dbo_Orders_IR {
	constructor(
		OrderID_IR,
		CustomerID,
		EmployeeID_IR,
		OrderDate,
		RequiredDate,
		ShippedDate,
		ShipVia_IR,
		Freight,
		ShipName,
		ShipAddress,
		ShipCity,
		ShipRegion,
		ShipPostalCode,
		ShipCountry
	)
	{
		this.OrderID_IR = OrderID_IR;
		this.CustomerID = CustomerID;
		this.EmployeeID_IR = EmployeeID_IR;
		this.OrderDate = OrderDate;
		this.RequiredDate = RequiredDate;
		this.ShippedDate = ShippedDate;
		this.ShipVia_IR = ShipVia_IR;
		this.Freight = Freight;
		this.ShipName = ShipName;
		this.ShipAddress = ShipAddress;
		this.ShipCity = ShipCity;
		this.ShipRegion = ShipRegion;
		this.ShipPostalCode = ShipPostalCode;
		this.ShipCountry = ShipCountry;
	}
	FK_Orders_Customers_Ref_IR;
	FK_Orders_Employees_Ref_IR;
	FK_Orders_Shippers_Ref_IR;
	OrderID_IR;
	CustomerID;
	EmployeeID_IR;
	OrderDate;
	RequiredDate;
	ShippedDate;
	ShipVia_IR;
	Freight;
	ShipName;
	ShipAddress;
	ShipCity;
	ShipRegion;
	ShipPostalCode;
	ShipCountry;
}
