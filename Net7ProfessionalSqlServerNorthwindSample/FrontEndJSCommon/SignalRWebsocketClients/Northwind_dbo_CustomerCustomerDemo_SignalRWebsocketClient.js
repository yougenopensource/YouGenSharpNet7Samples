/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_Northwind_dbo_CustomerCustomerDemo = baseUrlSignalR_Northwind + '/Northwind_dbo_CustomerCustomerDemo_Hub';
const connection_Northwind_dbo_CustomerCustomerDemo = new signalR.HubConnectionBuilder()
	.withUrl(url_Northwind_dbo_CustomerCustomerDemo)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_Northwind_dbo_CustomerCustomerDemo() {
	try {
		await connection_Northwind_dbo_CustomerCustomerDemo.start();
		console.log('SignalR Connected to url:  ' + url_Northwind_dbo_CustomerCustomerDemo);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_Northwind_dbo_CustomerCustomerDemo(), 5000);
	}
}
async function Stop_connection_Northwind_dbo_CustomerCustomerDemo() {
	try {
		await connection_Northwind_dbo_CustomerCustomerDemo.stop();
		console.log('SignalR Disconnected from url:  ' + url_Northwind_dbo_CustomerCustomerDemo);
	} catch (error) {
		console.log(error);
	}
}
async function Northwind_dbo_CustomerCustomerDemo_IR_GetAll() {
	try {
		let response = await connection_Northwind_dbo_CustomerCustomerDemo.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_CustomerCustomerDemo_IR_GetByCustomerIDAndCustomerTypeID(CustomerID,CustomerTypeID) {
	try {
		let response = await connection_Northwind_dbo_CustomerCustomerDemo.invoke('GetByCustomerIDAndCustomerTypeID',CustomerID,CustomerTypeID);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_CustomerCustomerDemo_IR_Create(input) {
	try {
		let response = await connection_Northwind_dbo_CustomerCustomerDemo.invoke('Create',input);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_CustomerCustomerDemo_IR_UpdateByCustomerIDAndCustomerTypeID(CustomerID,CustomerTypeID,input) {
	try {
		await connection_Northwind_dbo_CustomerCustomerDemo.invoke('UpdateByCustomerIDAndCustomerTypeID',CustomerID,CustomerTypeID,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_CustomerCustomerDemo_IR_DeleteByCustomerIDAndCustomerTypeID(CustomerID,CustomerTypeID) {
	try {
		await connection_Northwind_dbo_CustomerCustomerDemo.invoke('DeleteByCustomerIDAndCustomerTypeID',CustomerID,CustomerTypeID);
	} catch (error) {
		// console.log(error);
	}
}
