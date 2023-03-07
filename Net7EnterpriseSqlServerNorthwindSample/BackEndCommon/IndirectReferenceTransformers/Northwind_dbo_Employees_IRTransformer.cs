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
	public Northwind_dbo_Employees_IR ToIndirectModel(Northwind_dbo_Employees input, Boolean isSecondaryLookup = false)
	{
		var retData = new Northwind_dbo_Employees_IR(
			employeeID_IR_ : _encryptionDecryptionService!.EncInt32(input.EmployeeID),
			lastName_ : input.LastName,
			firstName_ : input.FirstName,
			title_ : input.Title,
			titleOfCourtesy_ : input.TitleOfCourtesy,
			birthDate_ : input.BirthDate,
			hireDate_ : input.HireDate,
			address_ : input.Address,
			city_ : input.City,
			region_ : input.Region,
			postalCode_ : input.PostalCode,
			country_ : input.Country,
			homePhone_ : input.HomePhone,
			extension_ : input.Extension,
			photo_ : input.Photo,
			notes_ : input.Notes,
			reportsTo_IR_ : _encryptionDecryptionService!.EncInt32Nullable(input.ReportsTo),
			photoPath_ : input.PhotoPath
			);
		if (input.FK_Employees_Employees_Ref != null) retData.FK_Employees_Employees_Ref_IR = ToIndirectModel(input.FK_Employees_Employees_Ref!, true);
		if (!isSecondaryLookup && input.FK_Employees_Employees_RefBy!.Any()) retData.FK_Employees_Employees_RefBy_IR = input.FK_Employees_Employees_RefBy!.Select(x => ToIndirectModel(x, true)).ToList()!;
		if (!isSecondaryLookup && input.FK_EmployeeTerritories_Employees_RefBy!.Any()) retData.FK_EmployeeTerritories_Employees_RefBy_IR = input.FK_EmployeeTerritories_Employees_RefBy!.Select(x => ToIndirectModel(x, true)).ToList()!;
		if (!isSecondaryLookup && input.FK_Orders_Employees_RefBy!.Any()) retData.FK_Orders_Employees_RefBy_IR = input.FK_Orders_Employees_RefBy!.Select(x => ToIndirectModel(x, true)).ToList()!;
			retData.PrimaryKeyHashedForUniqueObjectComparison = _encryptionDecryptionService!.CreateHash(retData.EmployeeID_IR);
		return retData;
	}
	public Northwind_dbo_Employees ToEntity(Northwind_dbo_Employees_IR input, Boolean isSecondaryLookup = false)
	{
		var retData = new Northwind_dbo_Employees(		
			employeeID_ : _encryptionDecryptionService.DecInt32(input.EmployeeID_IR),
			lastName_ : input.LastName ?? String.Empty,
			firstName_ : input.FirstName ?? String.Empty,
			title_ : input.Title,
			titleOfCourtesy_ : input.TitleOfCourtesy,
			birthDate_ : input.BirthDate,
			hireDate_ : input.HireDate,
			address_ : input.Address,
			city_ : input.City,
			region_ : input.Region,
			postalCode_ : input.PostalCode,
			country_ : input.Country,
			homePhone_ : input.HomePhone,
			extension_ : input.Extension,
			photo_ : input.Photo,
			notes_ : input.Notes,
			reportsTo_ : _encryptionDecryptionService.DecInt32Nullable(input.ReportsTo_IR),
			photoPath_ : input.PhotoPath
			);
		if (input.FK_Employees_Employees_Ref_IR != null) retData.FK_Employees_Employees_Ref = ToEntity(input.FK_Employees_Employees_Ref_IR!, true);
		return retData;
	}
}
