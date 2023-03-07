/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Database Stored Procedure Call")]
[RequireHttps]
public class Northwind_dbo_Sales_by_Year_StoredProcedure_Controller : ControllerBase
{
	private readonly INorthwind_dbo_Sales_by_Year_StoredProcedure_RequestHandler _requestHandler;
	public Northwind_dbo_Sales_by_Year_StoredProcedure_Controller(INorthwind_dbo_Sales_by_Year_StoredProcedure_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Call database stored procedure of Northwind.dbo.Sales_by_Year
	/// </summary>
	[HttpPost, Route("Northwind_dbo_Sales_by_Year_StoredProcedure/Call_Sales_by_Year")]
	public async Task<IEnumerable<Northwind_dbo_Sales_by_Year_OM_IR>?> Call_Sales_by_Year([FromBody]Northwind_dbo_Sales_by_Year_IM_IR input)
	{
		return await _requestHandler.HandleCall_Northwind_dbo_Sales_by_Year(input);
	}
}
