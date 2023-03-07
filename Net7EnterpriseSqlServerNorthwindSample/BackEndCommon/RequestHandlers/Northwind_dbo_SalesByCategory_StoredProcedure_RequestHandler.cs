/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_Common.Validators;
using Northwind_BackEndCommon.IndirectReferenceTransformers;
using Northwind_BackEndCommon.Services;
namespace Northwind_BackEndCommon.RequestHandlers;
public class Northwind_dbo_SalesByCategory_StoredProcedure_RequestHandler : INorthwind_dbo_SalesByCategory_StoredProcedure_RequestHandler
{
    private readonly ILogger<Northwind_dbo_SalesByCategory_StoredProcedure_RequestHandler> _logger;
    private readonly IEncryptionDecryptionService _encryptionDecryptionService;
    private readonly IIRTransformers _indirectReferenceTransformers;
    private readonly INorthwind_dbo_SalesByCategory_StoredProcedure_Repository _repository;
    private readonly Northwind_dbo_SalesByCategory_IM_IR_FluentValidator _inputValidator;
    public Northwind_dbo_SalesByCategory_StoredProcedure_RequestHandler(
        ILogger<Northwind_dbo_SalesByCategory_StoredProcedure_RequestHandler> logger
        ,IEncryptionDecryptionService encryptionDecryptionService
        ,IIRTransformers indirectReferenceTransformers
        ,INorthwind_dbo_SalesByCategory_StoredProcedure_Repository repository
        ,Northwind_dbo_SalesByCategory_IM_IR_FluentValidator inputValidator
    )
    {
        _logger = logger;
        _encryptionDecryptionService = encryptionDecryptionService;
        _indirectReferenceTransformers = indirectReferenceTransformers;
        _repository = repository;
        _inputValidator = inputValidator;        
    }
	//Main Handlers
	public async Task<IEnumerable<Northwind_dbo_SalesByCategory_OM_IR>?> HandleCall_Northwind_dbo_SalesByCategory<T>(T irModel) where T : Northwind_dbo_SalesByCategory_IM_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleCall_Northwind_dbo_SalesByCategory(irModel);
		var retData = await _repository.Call_Northwind_dbo_SalesByCategory(entity!);
		await PostHandleCall_Northwind_dbo_SalesByCategory(irModel);
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_SalesByCategory_OM_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	//PreCRUD Handlers
	private async Task PreHandleCall_Northwind_dbo_SalesByCategory<T>(T irModel) where T : Northwind_dbo_SalesByCategory_IM_IR
	{
		// Add preCRUD calls/events
		await _inputValidator.ValidateModelAndThrow(irModel);
	}
	//PostCRUD Handlers
	private async Task PostHandleCall_Northwind_dbo_SalesByCategory<T>(T irModel) where T : Northwind_dbo_SalesByCategory_IM_IR
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
}
