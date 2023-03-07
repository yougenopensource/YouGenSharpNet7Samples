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
	public Northwind_dbo_Suppliers_IR ToIndirectModel(Northwind_dbo_Suppliers input, Boolean isSecondaryLookup = false)
	{
		var retData = new Northwind_dbo_Suppliers_IR(
			supplierID_IR_ : _encryptionDecryptionService!.EncInt32(input.SupplierID),
			companyName_ : input.CompanyName,
			contactName_ : input.ContactName,
			contactTitle_ : input.ContactTitle,
			address_ : input.Address,
			city_ : input.City,
			region_ : input.Region,
			postalCode_ : input.PostalCode,
			country_ : input.Country,
			phone_ : input.Phone,
			fax_ : input.Fax,
			homePage_ : input.HomePage
			);
		if (!isSecondaryLookup && input.FK_Products_Suppliers_RefBy!.Any()) retData.FK_Products_Suppliers_RefBy_IR = input.FK_Products_Suppliers_RefBy!.Select(x => ToIndirectModel(x, true)).ToList()!;
			retData.PrimaryKeyHashedForUniqueObjectComparison = _encryptionDecryptionService!.CreateHash(retData.SupplierID_IR);
		return retData;
	}
	public Northwind_dbo_Suppliers ToEntity(Northwind_dbo_Suppliers_IR input, Boolean isSecondaryLookup = false)
	{
		var retData = new Northwind_dbo_Suppliers(		
			supplierID_ : _encryptionDecryptionService.DecInt32(input.SupplierID_IR),
			companyName_ : input.CompanyName ?? String.Empty,
			contactName_ : input.ContactName,
			contactTitle_ : input.ContactTitle,
			address_ : input.Address,
			city_ : input.City,
			region_ : input.Region,
			postalCode_ : input.PostalCode,
			country_ : input.Country,
			phone_ : input.Phone,
			fax_ : input.Fax,
			homePage_ : input.HomePage
			);
		return retData;
	}
}
