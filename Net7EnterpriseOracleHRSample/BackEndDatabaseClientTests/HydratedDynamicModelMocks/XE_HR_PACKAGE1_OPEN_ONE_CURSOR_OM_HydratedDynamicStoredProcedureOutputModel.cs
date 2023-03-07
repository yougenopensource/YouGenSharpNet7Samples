/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Tynamix.ObjectFiller;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClientTests.HydratedDynamicEntities;
public partial class XE_HR_HydratedDynamicEntities  : XE_HR_HydratedDynamicEntitiesBase
{
	protected Filler<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM> _XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_Filler = new Filler<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM>();
	protected FillerSetup? _XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_FillerSetup;
	public FillerSetup GetXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_FillerSetup(Boolean onlyFillExplicitlyNamedProperties)
	{
		if (_XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_FillerSetup != null)
			return _XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_FillerSetup;
		_XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_FillerSetup = _XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.Result;
		return _XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_FillerSetup;
	}
	public XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM GetHydratedDynamicXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM(Boolean onlyFillExplicitlyNamedProperties = true)
	{
		return GetHydratedDynamicIEnumerableOfXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM(1, onlyFillExplicitlyNamedProperties).First();
	}
	public IEnumerable<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM> GetHydratedDynamicIEnumerableOfXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true)
	{
		_XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_Filler.Setup(GetXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_FillerSetup(onlyFillExplicitlyNamedProperties));
		var retObjects = _XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_Filler.Create(numberToCreate);
		FillInnerTypes(retObjects);
		return retObjects;
	}
	private void FillInnerTypes(IEnumerable<XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM> entities)
	{
		foreach (var entity in entities)
		{
			entity.Query1_Results = GetHydratedDynamicIEnumerableOfXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_Query1(1);
		}
	}
}
