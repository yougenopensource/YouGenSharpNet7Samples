/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const controllerRoute = '/Northwind_dbo_Suppliers';
async function Northwind_dbo_Suppliers_IR_GetAll() {
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
async function Northwind_dbo_Suppliers_IR_GetByCompanyName(CompanyName) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'GetByCompanyName?' + GetUriForParamsForCompanyName(CompanyName);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Suppliers_IR_GetBySupplierID(SupplierID_IR) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'GetBySupplierID?' + GetUriForParamsForSupplierID(SupplierID_IR);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Suppliers_IR_GetByPostalCode(PostalCode) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'GetByPostalCode?' + GetUriForParamsForPostalCode(PostalCode);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Suppliers_IR_Create(input) {
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
async function Northwind_dbo_Suppliers_IR_UpdateByCompanyName(CompanyName,input) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'UpdateByCompanyName?' + GetUriForParamsForCompanyName(CompanyName);
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
async function Northwind_dbo_Suppliers_IR_UpdateBySupplierID(SupplierID_IR,input) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'UpdateBySupplierID?' + GetUriForParamsForSupplierID(SupplierID_IR);
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
async function Northwind_dbo_Suppliers_IR_UpdateByPostalCode(PostalCode,input) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'UpdateByPostalCode?' + GetUriForParamsForPostalCode(PostalCode);
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
async function Northwind_dbo_Suppliers_IR_DeleteByCompanyName(CompanyName) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'DeleteByCompanyName?' + GetUriForParamsForCompanyName(CompanyName);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Suppliers_IR_DeleteBySupplierID(SupplierID_IR) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'DeleteBySupplierID?' + GetUriForParamsForSupplierID(SupplierID_IR);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Suppliers_IR_DeleteByPostalCode(PostalCode) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'DeleteByPostalCode?' + GetUriForParamsForPostalCode(PostalCode);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
function GetUriForParamsForCompanyName(CompanyName) {
	const urlParams = new URLSearchParams({
		"CompanyName": CompanyName
	});
	return urlParams.toString();
}
function GetUriForParamsForSupplierID(SupplierID_IR) {
	const urlParams = new URLSearchParams({
		"SupplierID_IR": SupplierID_IR
	});
	return urlParams.toString();
}
function GetUriForParamsForPostalCode(PostalCode) {
	const urlParams = new URLSearchParams({
		"PostalCode": PostalCode
	});
	return urlParams.toString();
}
