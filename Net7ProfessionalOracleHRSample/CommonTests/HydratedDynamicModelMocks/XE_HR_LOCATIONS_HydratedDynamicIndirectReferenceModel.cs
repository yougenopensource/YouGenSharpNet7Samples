/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
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
using Tynamix.ObjectFiller;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndCommon.Services;
namespace XE_HR_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
public partial class XE_HR_HydratedDynamicIndirectReferenceTransformerModels : XE_HR_HydratedDynamicIndirectReferenceTransformerModelsBase
{
	protected Filler<XE_HR_LOCATIONS_IR> _XE_HR_LOCATIONS_IR_Filler = new Filler<XE_HR_LOCATIONS_IR>();
	protected FillerSetup? _XE_HR_LOCATIONS_IR_FillerSetup;
	public FillerSetup GetXE_HR_LOCATIONS_IR_FillerSetup(Boolean onlyFillExplicitlyNamedProperties, 
		Boolean fillPrimaryKey = false)
	{
		if (_XE_HR_LOCATIONS_IR_FillerSetup != null)
			return _XE_HR_LOCATIONS_IR_FillerSetup;
		_XE_HR_LOCATIONS_IR_FillerSetup = _XE_HR_LOCATIONS_IR_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.LOCATION_ID_IR).Use(() => (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty))
		.OnProperty(x => x.STREET_ADDRESS).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.POSTAL_CODE).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(12)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.CITY).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(30)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.STATE_PROVINCE).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(25)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.COUNTRY_ID).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(2)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		// Foreign key entities
		.OnProperty(x => x.LOC_C_ID_FK_Ref_IR).IgnoreIt()
		// Entities that reference this entity by foreign key
		.OnProperty(x => x.DEPT_LOC_FK_RefBy_IR).IgnoreIt()
		.Result;
		return _XE_HR_LOCATIONS_IR_FillerSetup;
	}
	public XE_HR_LOCATIONS_IR GetHydratedDynamicXE_HR_LOCATIONS_IR(Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		return GetHydratedDynamicIEnumerableOfXE_HR_LOCATIONS_IR(1, 
			onlyFillExplicitlyNamedProperties, 
			fillPrimaryKey, 
			fillInnerForeignKeys, 
			fillInnerPrimaryKeyReferencedBy).First();
	}
	public IEnumerable<XE_HR_LOCATIONS_IR> GetHydratedDynamicIEnumerableOfXE_HR_LOCATIONS_IR(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		_XE_HR_LOCATIONS_IR_Filler.Setup(GetXE_HR_LOCATIONS_IR_FillerSetup(onlyFillExplicitlyNamedProperties, fillPrimaryKey));
		var retObjects =  _XE_HR_LOCATIONS_IR_Filler.Create(numberToCreate);
		if (fillInnerForeignKeys) FillInnerForeignKeys(retObjects);
        if (fillInnerPrimaryKeyReferencedBy) FillInnerPrimaryKeyReferencedBy(retObjects);
		return retObjects;
	}
	private void FillInnerForeignKeys(IEnumerable<XE_HR_LOCATIONS_IR> irModels)
	{
		foreach (var irModel in irModels)
		{
			irModel.LOC_C_ID_FK_Ref_IR = GetHydratedDynamicXE_HR_COUNTRIES_IR();
		}
	}
	private void FillInnerPrimaryKeyReferencedBy(IEnumerable<XE_HR_LOCATIONS_IR> irModels)
	{
		foreach (var irModel in irModels)
		{
			// irModel.DEPT_LOC_FK_RefBy_IR!.Add(GetHydratedDynamicXE_HR_DEPARTMENTS_IR());
		}
	}
}
