/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_Northwind_dbo_ProductsAndCategories_StoredProcedure = baseUrlSignalR_Northwind + '/Northwind_dbo_ProductsAndCategories_StoredProcedure_Hub';
const connection_Northwind_dbo_ProductsAndCategories_StoredProcedure = new signalR.HubConnectionBuilder()
	.withUrl(url_Northwind_dbo_ProductsAndCategories_StoredProcedure)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_Northwind_dbo_ProductsAndCategories_StoredProcedure() {
	try {
		await connection_Northwind_dbo_ProductsAndCategories_StoredProcedure.start();
		console.log('SignalR Connected to url:  ' + url_Northwind_dbo_ProductsAndCategories_StoredProcedure);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_Northwind_dbo_ProductsAndCategories_StoredProcedure(), 5000);
	}
}
async function Stop_connection_Northwind_dbo_ProductsAndCategories_StoredProcedure() {
	try {
		await connection_Northwind_dbo_ProductsAndCategories_StoredProcedure.stop();
		console.log('SignalR Disconnected from url:  ' + url_Northwind_dbo_ProductsAndCategories_StoredProcedure);
	} catch (error) {
		console.log(error);
	}
}
async function Call_Northwind_dbo_ProductsAndCategories_StoredProcedure_IR() {
	try {
		let response = await connection_Northwind_dbo_ProductsAndCategories_StoredProcedure.invoke('Call_Northwind_dbo_ProductsAndCategories_StoredProcedure');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
