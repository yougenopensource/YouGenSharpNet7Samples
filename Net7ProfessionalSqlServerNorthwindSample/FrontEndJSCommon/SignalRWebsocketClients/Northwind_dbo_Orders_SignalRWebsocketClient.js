/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_Northwind_dbo_Orders = baseUrlSignalR_Northwind + '/Northwind_dbo_Orders_Hub';
const connection_Northwind_dbo_Orders = new signalR.HubConnectionBuilder()
	.withUrl(url_Northwind_dbo_Orders)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_Northwind_dbo_Orders() {
	try {
		await connection_Northwind_dbo_Orders.start();
		console.log('SignalR Connected to url:  ' + url_Northwind_dbo_Orders);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_Northwind_dbo_Orders(), 5000);
	}
}
async function Stop_connection_Northwind_dbo_Orders() {
	try {
		await connection_Northwind_dbo_Orders.stop();
		console.log('SignalR Disconnected from url:  ' + url_Northwind_dbo_Orders);
	} catch (error) {
		console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_GetAll() {
	try {
		let response = await connection_Northwind_dbo_Orders.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_GetByCustomerID(CustomerID) {
	try {
		let response = await connection_Northwind_dbo_Orders.invoke('GetByCustomerID',CustomerID);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_GetByEmployeeID(EmployeeID_IR) {
	try {
		let response = await connection_Northwind_dbo_Orders.invoke('GetByEmployeeID',EmployeeID_IR);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_GetByOrderDate(OrderDate) {
	try {
		let response = await connection_Northwind_dbo_Orders.invoke('GetByOrderDate',OrderDate);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_GetByOrderID(OrderID_IR) {
	try {
		let response = await connection_Northwind_dbo_Orders.invoke('GetByOrderID',OrderID_IR);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_GetByShippedDate(ShippedDate) {
	try {
		let response = await connection_Northwind_dbo_Orders.invoke('GetByShippedDate',ShippedDate);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_GetByShipVia(ShipVia_IR) {
	try {
		let response = await connection_Northwind_dbo_Orders.invoke('GetByShipVia',ShipVia_IR);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_GetByShipPostalCode(ShipPostalCode) {
	try {
		let response = await connection_Northwind_dbo_Orders.invoke('GetByShipPostalCode',ShipPostalCode);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_Create(input) {
	try {
		let response = await connection_Northwind_dbo_Orders.invoke('Create',input);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_UpdateByCustomerID(CustomerID,input) {
	try {
		await connection_Northwind_dbo_Orders.invoke('UpdateByCustomerID',CustomerID,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_UpdateByEmployeeID(EmployeeID_IR,input) {
	try {
		await connection_Northwind_dbo_Orders.invoke('UpdateByEmployeeID',EmployeeID_IR,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_UpdateByOrderDate(OrderDate,input) {
	try {
		await connection_Northwind_dbo_Orders.invoke('UpdateByOrderDate',OrderDate,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_UpdateByOrderID(OrderID_IR,input) {
	try {
		await connection_Northwind_dbo_Orders.invoke('UpdateByOrderID',OrderID_IR,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_UpdateByShippedDate(ShippedDate,input) {
	try {
		await connection_Northwind_dbo_Orders.invoke('UpdateByShippedDate',ShippedDate,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_UpdateByShipVia(ShipVia_IR,input) {
	try {
		await connection_Northwind_dbo_Orders.invoke('UpdateByShipVia',ShipVia_IR,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_UpdateByShipPostalCode(ShipPostalCode,input) {
	try {
		await connection_Northwind_dbo_Orders.invoke('UpdateByShipPostalCode',ShipPostalCode,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_DeleteByCustomerID(CustomerID) {
	try {
		await connection_Northwind_dbo_Orders.invoke('DeleteByCustomerID',CustomerID);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_DeleteByEmployeeID(EmployeeID_IR) {
	try {
		await connection_Northwind_dbo_Orders.invoke('DeleteByEmployeeID',EmployeeID_IR);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_DeleteByOrderDate(OrderDate) {
	try {
		await connection_Northwind_dbo_Orders.invoke('DeleteByOrderDate',OrderDate);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_DeleteByOrderID(OrderID_IR) {
	try {
		await connection_Northwind_dbo_Orders.invoke('DeleteByOrderID',OrderID_IR);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_DeleteByShippedDate(ShippedDate) {
	try {
		await connection_Northwind_dbo_Orders.invoke('DeleteByShippedDate',ShippedDate);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_DeleteByShipVia(ShipVia_IR) {
	try {
		await connection_Northwind_dbo_Orders.invoke('DeleteByShipVia',ShipVia_IR);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Orders_IR_DeleteByShipPostalCode(ShipPostalCode) {
	try {
		await connection_Northwind_dbo_Orders.invoke('DeleteByShipPostalCode',ShipPostalCode);
	} catch (error) {
		// console.log(error);
	}
}
