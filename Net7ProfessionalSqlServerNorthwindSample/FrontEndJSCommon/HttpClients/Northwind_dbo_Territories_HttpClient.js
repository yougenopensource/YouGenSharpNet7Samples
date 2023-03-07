/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const controllerRoute = '/Northwind_dbo_Territories';
async function Northwind_dbo_Territories_IR_GetAll() {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'GetAll';
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Territories_IR_GetByTerritoryID(TerritoryID) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'GetByTerritoryID?' + GetUriForParamsForTerritoryID(TerritoryID);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Territories_IR_Create(input) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'Create';
	config.method = 'post';
	config.data = input;
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Territories_IR_UpdateByTerritoryID(TerritoryID,input) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'UpdateByTerritoryID?' + GetUriForParamsForTerritoryID(TerritoryID);
	config.method = 'put';
	config.data = input;
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Territories_IR_DeleteByTerritoryID(TerritoryID) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'DeleteByTerritoryID?' + GetUriForParamsForTerritoryID(TerritoryID);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
function GetUriForParamsForTerritoryID(TerritoryID) {
	const urlParams = new URLSearchParams({
		"TerritoryID": TerritoryID
	});
	return urlParams.toString();
}
