/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedDynamicNorthwind_dbo_CustOrdersDetail(fillPrimaryKey = false) {
	var retObj = new Northwind_dbo_CustOrdersDetail_OM_IR();
	retObj.ProductName = generateString(40);
	retObj.UnitPrice = generateDecimal(19,4);
	retObj.Quantity = generateInt16();
	retObj.Discount = generateInt32();
	retObj.ExtendedPrice = generateDecimal(19,4);
	return retObj;
}
