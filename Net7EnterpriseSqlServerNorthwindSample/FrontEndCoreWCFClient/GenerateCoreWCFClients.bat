echo "You must have the CLI tooling called dotnet-svcutil installed on this machine to run this batch file."
echo "To install the tooling, run the following command in a terminal: dotnet tool install --global dotnet-svcutil"
echo "Start up the debugger on the CoreWCFServer project before running this batch file."
echo "You must have the CLI tooling called dotnet-svcutil installed on this machine to run this batch file."
echo "Once this script completes, Add the project found at ../FrontEndCoreWCFClientTests/Northwind_FrontEndCoreWCFClientTests.csproj to this solution."
dotnet-svcutil https://localhost:5001/Northwind_dbo_Categories_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Categories_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_CustomerCustomerDemo_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_CustomerCustomerDemo_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_CustomerDemographics_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_CustomerDemographics_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Customers_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Customers_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Employees_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Employees_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_EmployeeTerritories_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_EmployeeTerritories_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Order_Details_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Order_Details_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Orders_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Orders_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Products_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Products_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Region_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Region_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Shippers_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Shippers_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Suppliers_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Suppliers_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Territories_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Territories_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Alphabetical_list_of_products_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Alphabetical_list_of_products_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Category_Sales_for_1997_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Category_Sales_for_1997_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Current_Product_List_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Current_Product_List_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Customer_and_Suppliers_by_City_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Customer_and_Suppliers_by_City_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Invoices_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Invoices_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Order_Details_Extended_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Order_Details_Extended_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Order_Subtotals_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Order_Subtotals_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Orders_Qry_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Orders_Qry_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Product_Sales_for_1997_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Product_Sales_for_1997_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Products_Above_Average_Price_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Products_Above_Average_Price_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Products_by_Category_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Products_by_Category_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Quarterly_Orders_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Quarterly_Orders_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Sales_by_Category_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Sales_by_Category_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Sales_Totals_by_Amount_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Sales_Totals_by_Amount_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Summary_of_Sales_by_Quarter_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Summary_of_Sales_by_Quarter_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Summary_of_Sales_by_Year_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Summary_of_Sales_by_Year_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_CustOrderHist_StoredProcedure_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_CustOrderHist_StoredProcedure_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_CustOrdersDetail_StoredProcedure_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_CustOrdersDetail_StoredProcedure_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_CustOrdersOrders_StoredProcedure_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_CustOrdersOrders_StoredProcedure_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Employee_Sales_by_Country_StoredProcedure_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Employee_Sales_by_Country_StoredProcedure_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_ProductsAndCategories_StoredProcedure_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_ProductsAndCategories_StoredProcedure_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Sales_by_Year_StoredProcedure_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Sales_by_Year_StoredProcedure_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_SalesByCategory_StoredProcedure_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_SalesByCategory_StoredProcedure_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
dotnet-svcutil https://localhost:5001/Northwind_dbo_Ten_Most_Expensive_Products_StoredProcedure_Service?wsdl -d CoreWCFClients -n "*,Northwind_FrontEndCoreWCFClient.CoreWCFClients" -o "Northwind_dbo_Ten_Most_Expensive_Products_StoredProcedure_WCFClient" -r "../Common/Northwind_Common.csproj" -ser DataContractSerializer -ac
