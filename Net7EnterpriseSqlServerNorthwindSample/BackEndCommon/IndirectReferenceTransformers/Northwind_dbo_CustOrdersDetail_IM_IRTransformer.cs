/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCommon.IndirectReferenceTransformers;
public partial class IRTransformers : IIRTransformers
{
	public Northwind_dbo_CustOrdersDetail_IM_IR ToIndirectModel(Northwind_dbo_CustOrdersDetail_IM input)
	{
		var retData = new Northwind_dbo_CustOrdersDetail_IM_IR(
			orderID_IR_ : _encryptionDecryptionService!.EncInt32Nullable(input.OrderID)
		);
		return retData;
	}
	public Northwind_dbo_CustOrdersDetail_IM ToEntity(Northwind_dbo_CustOrdersDetail_IM_IR input)
	{
		var retData = new Northwind_dbo_CustOrdersDetail_IM(		
			orderID_ : _encryptionDecryptionService.DecInt32Nullable(input.OrderID_IR)
		);
		return retData;
	}
}
