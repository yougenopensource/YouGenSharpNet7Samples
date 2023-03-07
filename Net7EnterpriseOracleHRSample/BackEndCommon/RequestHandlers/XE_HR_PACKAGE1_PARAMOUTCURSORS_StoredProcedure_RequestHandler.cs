/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_Common.Validators;
using XE_HR_BackEndCommon.IndirectReferenceTransformers;
using XE_HR_BackEndCommon.Services;
namespace XE_HR_BackEndCommon.RequestHandlers;
public class XE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_RequestHandler : IXE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_RequestHandler
{
    private readonly ILogger<XE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_RequestHandler> _logger;
    private readonly IEncryptionDecryptionService _encryptionDecryptionService;
    private readonly IIRTransformers _indirectReferenceTransformers;
    private readonly IXE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_Repository _repository;
    private readonly XE_HR_PACKAGE1_PARAMOUTCURSORS_IM_IR_FluentValidator _inputValidator;
    public XE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_RequestHandler(
        ILogger<XE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_RequestHandler> logger
        ,IEncryptionDecryptionService encryptionDecryptionService
        ,IIRTransformers indirectReferenceTransformers
        ,IXE_HR_PACKAGE1_PARAMOUTCURSORS_StoredProcedure_Repository repository
        ,XE_HR_PACKAGE1_PARAMOUTCURSORS_IM_IR_FluentValidator inputValidator
    )
    {
        _logger = logger;
        _encryptionDecryptionService = encryptionDecryptionService;
        _indirectReferenceTransformers = indirectReferenceTransformers;
        _repository = repository;
        _inputValidator = inputValidator;        
    }
	//Main Handlers
	public async Task<XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_IR?> HandleCall_XE_HR_PACKAGE1_PARAMOUTCURSORS<T>(T irModel) where T : XE_HR_PACKAGE1_PARAMOUTCURSORS_IM_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleCall_XE_HR_PACKAGE1_PARAMOUTCURSORS(irModel);
		var retData = await _repository.Call_XE_HR_PACKAGE1_PARAMOUTCURSORS(entity!);
		await PostHandleCall_XE_HR_PACKAGE1_PARAMOUTCURSORS(irModel);
		return retData == null ? null : _indirectReferenceTransformers.ToIndirectModel(retData);
	}
	//PreCRUD Handlers
	private async Task PreHandleCall_XE_HR_PACKAGE1_PARAMOUTCURSORS<T>(T irModel) where T : XE_HR_PACKAGE1_PARAMOUTCURSORS_IM_IR
	{
		// Add preCRUD calls/events
		await _inputValidator.ValidateModelAndThrow(irModel);
	}
	//PostCRUD Handlers
	private async Task PostHandleCall_XE_HR_PACKAGE1_PARAMOUTCURSORS<T>(T irModel) where T : XE_HR_PACKAGE1_PARAMOUTCURSORS_IM_IR
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
}
