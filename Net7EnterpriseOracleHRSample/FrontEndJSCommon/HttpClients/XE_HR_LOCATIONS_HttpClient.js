/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const controllerRoute = '/XE_HR_LOCATIONS';
async function XE_HR_LOCATIONS_IR_GetAll() {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
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
async function XE_HR_LOCATIONS_IR_GetByCITY(CITY) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'GetByCITY?' + GetUriForParamsForCITY(CITY);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_GetByCOUNTRY_ID(COUNTRY_ID) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'GetByCOUNTRY_ID?' + GetUriForParamsForCOUNTRY_ID(COUNTRY_ID);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_GetByLOCATION_ID(LOCATION_ID_IR) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'GetByLOCATION_ID?' + GetUriForParamsForLOCATION_ID(LOCATION_ID_IR);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_GetBySTATE_PROVINCE(STATE_PROVINCE) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'GetBySTATE_PROVINCE?' + GetUriForParamsForSTATE_PROVINCE(STATE_PROVINCE);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_Create(input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
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
async function XE_HR_LOCATIONS_IR_UpdateByCITY(CITY,input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'UpdateByCITY?' + GetUriForParamsForCITY(CITY);
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
async function XE_HR_LOCATIONS_IR_UpdateByCOUNTRY_ID(COUNTRY_ID,input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'UpdateByCOUNTRY_ID?' + GetUriForParamsForCOUNTRY_ID(COUNTRY_ID);
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
async function XE_HR_LOCATIONS_IR_UpdateByLOCATION_ID(LOCATION_ID_IR,input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'UpdateByLOCATION_ID?' + GetUriForParamsForLOCATION_ID(LOCATION_ID_IR);
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
async function XE_HR_LOCATIONS_IR_UpdateBySTATE_PROVINCE(STATE_PROVINCE,input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'UpdateBySTATE_PROVINCE?' + GetUriForParamsForSTATE_PROVINCE(STATE_PROVINCE);
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
async function XE_HR_LOCATIONS_IR_DeleteByCITY(CITY) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'DeleteByCITY?' + GetUriForParamsForCITY(CITY);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_DeleteByCOUNTRY_ID(COUNTRY_ID) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'DeleteByCOUNTRY_ID?' + GetUriForParamsForCOUNTRY_ID(COUNTRY_ID);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_DeleteByLOCATION_ID(LOCATION_ID_IR) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'DeleteByLOCATION_ID?' + GetUriForParamsForLOCATION_ID(LOCATION_ID_IR);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_LOCATIONS_IR_DeleteBySTATE_PROVINCE(STATE_PROVINCE) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'DeleteBySTATE_PROVINCE?' + GetUriForParamsForSTATE_PROVINCE(STATE_PROVINCE);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
function GetUriForParamsForCITY(CITY) {
	const urlParams = new URLSearchParams({
		"CITY": CITY
	});
	return urlParams.toString();
}
function GetUriForParamsForCOUNTRY_ID(COUNTRY_ID) {
	const urlParams = new URLSearchParams({
		"COUNTRY_ID": COUNTRY_ID
	});
	return urlParams.toString();
}
function GetUriForParamsForLOCATION_ID(LOCATION_ID_IR) {
	const urlParams = new URLSearchParams({
		"LOCATION_ID_IR": LOCATION_ID_IR
	});
	return urlParams.toString();
}
function GetUriForParamsForSTATE_PROVINCE(STATE_PROVINCE) {
	const urlParams = new URLSearchParams({
		"STATE_PROVINCE": STATE_PROVINCE
	});
	return urlParams.toString();
}
