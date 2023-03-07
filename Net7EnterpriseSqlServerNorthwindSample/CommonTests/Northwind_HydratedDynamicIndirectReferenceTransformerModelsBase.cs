/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Newtonsoft.Json;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndCommon.Configuration;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
namespace Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
public class Northwind_HydratedDynamicIndirectReferenceTransformerModelsBase
{
	protected readonly CustomAppSettings? _customAppSettings;
	protected readonly IEncryptionDecryptionService? _encryptionDecryptionService;
	protected readonly DateTime _seedDateTime;
	protected readonly Int32 _range;
	protected readonly String _chars;
	protected readonly Int32 _maxByte;
	protected readonly Int32 _seedTimespan;
	public Northwind_HydratedDynamicIndirectReferenceTransformerModelsBase()
	{
		_customAppSettings = JsonConvert.DeserializeObject<CustomAppSettings>(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "appSettings.Test.json")));
		_encryptionDecryptionService = new EncryptionDecryptionService(_customAppSettings!.EncryptDecryptKey!);
		_seedDateTime = new DateTime(1995, 1, 1);
		_range = (DateTime.Today - _seedDateTime).Days;
		_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ";
		_maxByte = 127;
		_seedTimespan = 86400;
	}
}
