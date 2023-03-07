/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
namespace Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
public partial class Northwind_HydratedStaticIndirectReferenceTransformerModels : Northwind_HydratedStaticIndirectReferenceTransformerModelsBase
{
	public Northwind_dbo_Invoices_IR GetHydratedStaticNorthwind_dbo_Invoices_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Invoices_IR();
		retObj.ShipName = "c7Y7uzv2G4pEORnUlCiRmLoENgI7Yhue72nVN4O8";
		retObj.ShipAddress = "SVFfK11vZuqoEd MxLqTCL1M0eoEsaVEG Ty4Iz7GhzXgL1MYi5yhRuTw5tV";
		retObj.ShipCity = "L18NMa56I2yaO8I";
		retObj.ShipRegion = "CA5MeZvx9c7o9f7";
		retObj.ShipPostalCode = "oEzGF7ytQT";
		retObj.ShipCountry = "uwqohSAnonJVQ5U";
		retObj.CustomerID = (fillPrimaryKey ? "s6ZBe" : String.Empty);
		retObj.CustomerName = "ZyNifezJ9LbgBWmG29WmUwgYfvXG25L6JIyTC47n";
		retObj.Address = "820Z754PoLKbxWVoFnTR4ocW2WsVl43495K8PHeAxCL5BySPezAmWiccYGUo";
		retObj.City = "UULfL8DcyXEe 4l";
		retObj.Region = "I5u57fNxo qIsQ7";
		retObj.PostalCode = "wLkauFpAJE";
		retObj.Country = "C2NIHulysnDie7b";
		retObj.Salesperson = "l1CcMDZBzDEzy3FJzIq8i72lQTW5MqV";
		retObj.OrderID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.OrderDate = DateTime.Parse("7/22/1999 12:00:00 AM");
		retObj.RequiredDate = DateTime.Parse("12/3/2011 12:00:00 AM");
		retObj.ShippedDate = DateTime.Parse("7/4/2021 12:00:00 AM");
		retObj.ShipperName = "Fn4kEwUXniYmxXAWN8Gg2T1YCUZhLFjqNy9HEPn9";
		retObj.ProductID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.ProductName = "isOavQgXZh hNlDqew1xgV73vRAPGyxb64KRqz24";
		retObj.UnitPrice = (0.1291917172721554M);
		retObj.Quantity = (-3);
		retObj.Discount = (0.14949071F);
		retObj.ExtendedPrice = (0.6979664150339684M);
		retObj.Freight = (0.47103554925551305M);
		return retObj;
	}
}
