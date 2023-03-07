/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
public class Northwind_dbo_Shippers_RequestHandler : INorthwind_dbo_Shippers_RequestHandler
{
    private readonly ILogger<Northwind_dbo_Shippers_RequestHandler> _logger;
    private readonly IEncryptionDecryptionService _encryptionDecryptionService; 
    private readonly IIRTransformers _indirectReferenceTransformers;
    private readonly INorthwind_dbo_Shippers_Repository _repository;
    private readonly Northwind_dbo_Shippers_IR_FluentValidator_Create _createValidator;
    private readonly Northwind_dbo_Shippers_IR_FluentValidator_Read _readValidator;
    private readonly Northwind_dbo_Shippers_IR_FluentValidator_Update _updateValidator;
    private readonly Northwind_dbo_Shippers_IR_FluentValidator_Delete _deleteValidator;
    public Northwind_dbo_Shippers_RequestHandler(
        ILogger<Northwind_dbo_Shippers_RequestHandler> logger
        ,IEncryptionDecryptionService encryptionDecryptionService
        ,IIRTransformers indirectReferenceTransformers
        ,INorthwind_dbo_Shippers_Repository repository 
        ,Northwind_dbo_Shippers_IR_FluentValidator_Create createValidator
        ,Northwind_dbo_Shippers_IR_FluentValidator_Read readValidator
        ,Northwind_dbo_Shippers_IR_FluentValidator_Update updateValidator
        ,Northwind_dbo_Shippers_IR_FluentValidator_Delete deleteValidator
    )
    {
        _logger = logger;
        _encryptionDecryptionService = encryptionDecryptionService;
        _indirectReferenceTransformers = indirectReferenceTransformers;
        _repository = repository;
        _createValidator = createValidator;
        _readValidator = readValidator;
        _updateValidator = updateValidator;
        _deleteValidator = deleteValidator;
    }
	//Main Handlers
	public async Task<IEnumerable<Northwind_dbo_Shippers_IR>?> HandleGetAll()
	{
		await PreHandleGetAll();
		var retData = await _repository.GetAll();
		await PostHandleGetAll();
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_Shippers_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<IEnumerable<Northwind_dbo_Shippers_IR>?> HandleGetByShipperID(String? shipperID_IR)
	{
		await PreHandleGetByShipperID(shipperID_IR);
		var retData = await _repository.GetByShipperID(_encryptionDecryptionService.DecInt32(shipperID_IR));
		await PostHandleGetByShipperID(shipperID_IR);
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_Shippers_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<Northwind_dbo_Shippers_IR?> HandleCreate<T>(T irModel) where T : Northwind_dbo_Shippers_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleCreate(irModel);
		entity = await _repository.Create(entity!);
		if (entity != null) 
		{
			await PostHandleCreate(irModel);
			return _indirectReferenceTransformers.ToIndirectModel(entity!);
		}
		else
			return null;
	}
	public async Task HandleUpdateByShipperID<T>(String? shipperID_IR, T irModel) where T : Northwind_dbo_Shippers_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleUpdateByShipperID(shipperID_IR, irModel);
		await _repository.UpdateByShipperID(_encryptionDecryptionService.DecInt32(shipperID_IR), entity!);
		await PostHandleUpdateByShipperID(shipperID_IR, irModel);
	}
	public async Task HandleDeleteByShipperID(String? shipperID_IR)
	{
		await PreHandleDeleteByShipperID(shipperID_IR);
		await _repository.DeleteByShipperID(_encryptionDecryptionService.DecInt32(shipperID_IR));
		await PostHandleDeleteByShipperID(shipperID_IR);
	}
	//PreCRUD Handlers
	private async Task PreHandleGetAll()
	{
		// Add preCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PreHandleGetByShipperID(String? shipperID_IR)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Shippers_IR();
		selectorProperties.ShipperID_IR = shipperID_IR;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
	}
	private async Task PreHandleCreate(Northwind_dbo_Shippers_IR irModel)
	{
		// Add preCRUD calls/events
		await _createValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleUpdateByShipperID(String? shipperID_IR, Northwind_dbo_Shippers_IR irModel)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Shippers_IR();
		selectorProperties.ShipperID_IR = shipperID_IR;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
		await _updateValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleDeleteByShipperID(String? shipperID_IR)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Shippers_IR();
		selectorProperties.ShipperID_IR = shipperID_IR;
		await _deleteValidator.ValidateModelAndThrow(selectorProperties);
	}
	//PostCRUD Handlers
	private async Task PostHandleGetAll()
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleGetByShipperID(String? shipperID_IR)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleCreate(Northwind_dbo_Shippers_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleUpdateByShipperID(String? shipperID_IR, Northwind_dbo_Shippers_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleDeleteByShipperID(String? shipperID_IR)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
}
