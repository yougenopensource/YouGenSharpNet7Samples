/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_BackEndCommon.RequestHandlers;
namespace XE_HR_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: Departments table that shows details of departments where employees work. Contains 27 rows; references with locations, employees, and job_history tables.")]
[RequireHttps]
public class XE_HR_DEPARTMENTS_Controller : ControllerBase
{
	private readonly IXE_HR_DEPARTMENTS_RequestHandler _requestHandler;
	public XE_HR_DEPARTMENTS_Controller(IXE_HR_DEPARTMENTS_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of DEPARTMENTS table
	/// </summary>
	[HttpGet, Route("XE_HR_DEPARTMENTS/GetAll")]
	public async Task<IEnumerable<XE_HR_DEPARTMENTS_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of DEPARTMENTS table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("XE_HR_DEPARTMENTS/GetByDEPARTMENT_ID")]
	public async Task<IEnumerable<XE_HR_DEPARTMENTS_IR>?> GetByDEPARTMENT_ID(String? dEPARTMENT_ID_IR)
	{
		return await _requestHandler.HandleGetByDEPARTMENT_ID(dEPARTMENT_ID_IR);
	}
	/// <summary>
	/// Get record of DEPARTMENTS table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("XE_HR_DEPARTMENTS/GetByLOCATION_ID")]
	public async Task<IEnumerable<XE_HR_DEPARTMENTS_IR>?> GetByLOCATION_ID(String? lOCATION_ID_IR)
	{
		return await _requestHandler.HandleGetByLOCATION_ID(lOCATION_ID_IR);
	}
	/// <summary>
	/// Create and return record of DEPARTMENTS table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("XE_HR_DEPARTMENTS/Create")]
	public async Task<XE_HR_DEPARTMENTS_IR?> Create([FromBody]XE_HR_DEPARTMENTS_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of DEPARTMENTS table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("XE_HR_DEPARTMENTS/UpdateByDEPARTMENT_ID")]
	public async Task UpdateByDEPARTMENT_ID(String? dEPARTMENT_ID_IR, [FromBody]XE_HR_DEPARTMENTS_IR input)
	{
		await _requestHandler.HandleUpdateByDEPARTMENT_ID(dEPARTMENT_ID_IR, input);
	}
	/// <summary>
	/// Update record of DEPARTMENTS table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("XE_HR_DEPARTMENTS/UpdateByLOCATION_ID")]
	public async Task UpdateByLOCATION_ID(String? lOCATION_ID_IR, [FromBody]XE_HR_DEPARTMENTS_IR input)
	{
		await _requestHandler.HandleUpdateByLOCATION_ID(lOCATION_ID_IR, input);
	}
	/// <summary>
	/// Delete record of DEPARTMENTS table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("XE_HR_DEPARTMENTS/DeleteByDEPARTMENT_ID")]
	public async Task DeleteByDEPARTMENT_ID(String? dEPARTMENT_ID_IR)
	{
		await _requestHandler.HandleDeleteByDEPARTMENT_ID(dEPARTMENT_ID_IR);
	}
	/// <summary>
	/// Delete record of DEPARTMENTS table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("XE_HR_DEPARTMENTS/DeleteByLOCATION_ID")]
	public async Task DeleteByLOCATION_ID(String? lOCATION_ID_IR)
	{
		await _requestHandler.HandleDeleteByLOCATION_ID(lOCATION_ID_IR);
	}
}
