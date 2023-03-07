/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
	protected Filler<XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR> _XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR_Filler = new Filler<XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR>();
	protected FillerSetup? _XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR_FillerSetup;
	public FillerSetup GetXE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR_FillerSetup(Boolean onlyFillExplicitlyNamedProperties)
	{
		if (_XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR_FillerSetup != null)
			return _XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR_FillerSetup;
		_XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR_FillerSetup = _XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR_Filler.Setup(onlyFillExplicitlyNamedProperties)
		// Input parameters
		.OnProperty(x => x.VAR_INPUT).Use(() => Random.Shared.Next(Int32.MinValue, Int32.MaxValue))
		.Result;
		return _XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR_FillerSetup;
	}
	public XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR GetHydratedDynamicXE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR(Boolean onlyFillExplicitlyNamedProperties = true)
	{
		return GetHydratedDynamicIEnumerableOfXE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR(1, onlyFillExplicitlyNamedProperties).First();
	}
	public IEnumerable<XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR> GetHydratedDynamicIEnumerableOfXE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true)
	{
		_XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR_Filler.Setup(GetXE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR_FillerSetup(onlyFillExplicitlyNamedProperties));
		var retObjects =  _XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR_Filler.Create(numberToCreate);
		FillInnerTypes(retObjects);
		return retObjects;
	}
	private void FillInnerTypes(IEnumerable<XE_HR_PACKAGE1_RETURNSTRINGPROC_IM_IR> irModels)
	{
		foreach (var irModel in irModels)
		{
		}
	}
}
