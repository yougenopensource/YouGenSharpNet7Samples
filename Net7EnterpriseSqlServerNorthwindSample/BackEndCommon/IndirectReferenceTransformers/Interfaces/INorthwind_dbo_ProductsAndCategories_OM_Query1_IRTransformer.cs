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
public partial interface IIRTransformers
{
	Northwind_dbo_ProductsAndCategories_OM_Query1_IR? ToIndirectModel(Northwind_dbo_ProductsAndCategories_OM_Query1 input);
	Northwind_dbo_ProductsAndCategories_OM_Query1? ToEntity(Northwind_dbo_ProductsAndCategories_OM_Query1_IR input);
}
