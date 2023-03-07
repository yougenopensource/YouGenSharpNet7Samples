/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Tynamix.ObjectFiller;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClientTests.HydratedDynamicEntities;
public partial class XE_HR_HydratedDynamicEntities  : XE_HR_HydratedDynamicEntitiesBase
{
	protected Filler<XE_HR_REGIONS> _XE_HR_REGIONS_Filler = new Filler<XE_HR_REGIONS>();
	protected FillerSetup? _XE_HR_REGIONS_FillerSetup;
	public FillerSetup GetXE_HR_REGIONS_FillerSetup(Boolean onlyFillExplicitlyNamedProperties, 
		Boolean fillPrimaryKey = false)
	{
		if (_XE_HR_REGIONS_FillerSetup != null)
			return _XE_HR_REGIONS_FillerSetup;
		_XE_HR_REGIONS_FillerSetup = _XE_HR_REGIONS_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.REGION_ID).Use(() => (fillPrimaryKey ? Convert.ToInt32(1) : 0))
		.OnProperty(x => x.REGION_NAME).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(25)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		// Entities that reference this entity by foreign key
		.OnProperty(x => x.COUNTR_REG_FK_RefBy).IgnoreIt()
		.Result;
		return _XE_HR_REGIONS_FillerSetup;
	}
	public XE_HR_REGIONS GetHydratedDynamicXE_HR_REGIONS(Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false,	
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		return GetHydratedDynamicIEnumerableOfXE_HR_REGIONS(1,
			onlyFillExplicitlyNamedProperties, 
			fillPrimaryKey, 
			fillInnerForeignKeys, 
			fillInnerPrimaryKeyReferencedBy).First();
	}
	public IEnumerable<XE_HR_REGIONS> GetHydratedDynamicIEnumerableOfXE_HR_REGIONS(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		_XE_HR_REGIONS_Filler.Setup(GetXE_HR_REGIONS_FillerSetup(onlyFillExplicitlyNamedProperties, fillPrimaryKey));
		var retObjects = _XE_HR_REGIONS_Filler.Create(numberToCreate);
		if (fillInnerForeignKeys) FillInnerForeignKeys(retObjects);
        if (fillInnerPrimaryKeyReferencedBy) FillInnerPrimaryKeyReferencedBy(retObjects);
		return retObjects;
	}
	private void FillInnerForeignKeys(IEnumerable<XE_HR_REGIONS> entities)
	{
		foreach (var entity in entities)
		{
		}
	}
	private void FillInnerPrimaryKeyReferencedBy(IEnumerable<XE_HR_REGIONS> entities)
	{
		foreach (var entity in entities)
		{
			// entity.COUNTR_REG_FK_RefBy!.Add(GetHydratedDynamicXE_HR_COUNTRIES());
		}
	}
}
