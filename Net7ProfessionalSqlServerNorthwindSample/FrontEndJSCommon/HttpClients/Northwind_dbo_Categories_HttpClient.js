/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const controllerRoute = '/Northwind_dbo_Categories';
async function Northwind_dbo_Categories_IR_GetAll() {
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
async function Northwind_dbo_Categories_IR_GetByCategoryName(CategoryName) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'GetByCategoryName?' + GetUriForParamsForCategoryName(CategoryName);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Categories_IR_GetByCategoryID(CategoryID_IR) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'GetByCategoryID?' + GetUriForParamsForCategoryID(CategoryID_IR);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Categories_IR_Create(input) {
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
async function Northwind_dbo_Categories_IR_UpdateByCategoryName(CategoryName,input) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'UpdateByCategoryName?' + GetUriForParamsForCategoryName(CategoryName);
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
async function Northwind_dbo_Categories_IR_UpdateByCategoryID(CategoryID_IR,input) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'UpdateByCategoryID?' + GetUriForParamsForCategoryID(CategoryID_IR);
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
async function Northwind_dbo_Categories_IR_DeleteByCategoryName(CategoryName) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'DeleteByCategoryName?' + GetUriForParamsForCategoryName(CategoryName);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Categories_IR_DeleteByCategoryID(CategoryID_IR) {
	let config = {};
	config.baseURL = baseUrl_Northwind + controllerRoute;
	config.url = 'DeleteByCategoryID?' + GetUriForParamsForCategoryID(CategoryID_IR);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
function GetUriForParamsForCategoryName(CategoryName) {
	const urlParams = new URLSearchParams({
		"CategoryName": CategoryName
	});
	return urlParams.toString();
}
function GetUriForParamsForCategoryID(CategoryID_IR) {
	const urlParams = new URLSearchParams({
		"CategoryID_IR": CategoryID_IR
	});
	return urlParams.toString();
}
