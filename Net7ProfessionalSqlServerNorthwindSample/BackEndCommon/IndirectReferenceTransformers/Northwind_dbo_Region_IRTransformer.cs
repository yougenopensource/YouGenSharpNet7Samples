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
	public Northwind_dbo_Region_IR ToIndirectModel(Northwind_dbo_Region input, Boolean isSecondaryLookup = false)
	{
		var retData = new Northwind_dbo_Region_IR(
			regionID_IR_ : _encryptionDecryptionService!.EncInt32(input.RegionID),
			regionDescription_ : input.RegionDescription
			);
		if (!isSecondaryLookup && input.FK_Territories_Region_RefBy!.Any()) retData.FK_Territories_Region_RefBy_IR = input.FK_Territories_Region_RefBy!.Select(x => ToIndirectModel(x, true)).ToList()!;
			retData.PrimaryKeyHashedForUniqueObjectComparison = _encryptionDecryptionService!.CreateHash(retData.RegionID_IR);
		return retData;
	}
	public Northwind_dbo_Region ToEntity(Northwind_dbo_Region_IR input, Boolean isSecondaryLookup = false)
	{
		var retData = new Northwind_dbo_Region(		
			regionID_ : _encryptionDecryptionService.DecInt32(input.RegionID_IR),
			regionDescription_ : input.RegionDescription ?? String.Empty
			);
		return retData;
	}
}
