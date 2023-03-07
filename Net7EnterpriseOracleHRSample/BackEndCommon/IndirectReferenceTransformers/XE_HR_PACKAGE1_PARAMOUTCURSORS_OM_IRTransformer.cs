/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndCommon.Services;
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_BackEndCommon.IndirectReferenceTransformers;
public partial class IRTransformers : IIRTransformers
{
	public XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_IR ToIndirectModel(XE_HR_PACKAGE1_PARAMOUTCURSORS_OM input)
	{
		var retData = new XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_IR(
			cONVERTED_TO_VARCHAR2_ : input.CONVERTED_TO_VARCHAR2
		);
		if (input.Query1_Results != null && input.Query1_Results.Any()) retData.Query1_Results_IR = input.Query1_Results.Select(x => ToIndirectModel(x));
		if (input.Query2_Results != null && input.Query2_Results.Any()) retData.Query2_Results_IR = input.Query2_Results.Select(x => ToIndirectModel(x));
		return retData;
	}
	public XE_HR_PACKAGE1_PARAMOUTCURSORS_OM ToEntity(XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_IR input)
	{
		var retData = new XE_HR_PACKAGE1_PARAMOUTCURSORS_OM(		
			cONVERTED_TO_VARCHAR2_ : input.CONVERTED_TO_VARCHAR2
		);
		if (input.Query1_Results_IR != null && input.Query1_Results_IR.Any())retData.Query1_Results = input.Query1_Results_IR.Select(x => ToEntity(x));
		if (input.Query2_Results_IR != null && input.Query2_Results_IR.Any())retData.Query2_Results = input.Query2_Results_IR.Select(x => ToEntity(x));
		return retData;
	}
}
