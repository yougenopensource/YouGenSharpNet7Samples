/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCommon.IndirectReferenceTransformers;
public partial class IRTransformers : IIRTransformers
{
	public Northwind_dbo_Order_Details_Extended_IR ToIndirectModel(Northwind_dbo_Order_Details_Extended input)
	{
		var retData = new Northwind_dbo_Order_Details_Extended_IR(
			orderID_IR_ : _encryptionDecryptionService!.EncInt32(input.OrderID),
			productID_IR_ : _encryptionDecryptionService!.EncInt32(input.ProductID),
			productName_ : input.ProductName,
			unitPrice_ : input.UnitPrice,
			quantity_ : input.Quantity,
			discount_ : input.Discount,
			extendedPrice_ : input.ExtendedPrice
			);
		return retData;
	}
	public Northwind_dbo_Order_Details_Extended ToEntity(Northwind_dbo_Order_Details_Extended_IR input)
	{
		var retData = new Northwind_dbo_Order_Details_Extended(		
			orderID_ : _encryptionDecryptionService.DecInt32(input.OrderID_IR),
			productID_ : _encryptionDecryptionService.DecInt32(input.ProductID_IR),
			productName_ : input.ProductName ?? String.Empty,
			unitPrice_ : input.UnitPrice ?? default,
			quantity_ : input.Quantity ?? default,
			discount_ : input.Discount ?? default,
			extendedPrice_ : input.ExtendedPrice
			);
		return retData;
	}
}
