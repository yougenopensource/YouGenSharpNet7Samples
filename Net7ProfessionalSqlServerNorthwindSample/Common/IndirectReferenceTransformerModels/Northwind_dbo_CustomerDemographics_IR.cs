/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Northwind_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Indirect Referenced Model Description: N/A
/// </summary>
public class Northwind_dbo_CustomerDemographics_IR
{
	public Northwind_dbo_CustomerDemographics_IR() 
	{
	} 
	public Northwind_dbo_CustomerDemographics_IR(
		String? customerTypeID_,
		String? customerDesc_
	)
	{
		_customerTypeID = customerTypeID_;
		CustomerTypeID_OriginalValue = customerTypeID_;
		_customerDesc = customerDesc_;
		CustomerDesc_OriginalValue = customerDesc_;
		PrimaryKeyEncryptedForUpdateDeleteIdentification = customerTypeID_;
	}
	[JsonConstructor]
	public Northwind_dbo_CustomerDemographics_IR(
		String CustomerTypeID,
		String CustomerTypeID_OriginalValue,
		Boolean CustomerTypeID_HasBeenChanged,
		String? CustomerDesc,
		String? CustomerDesc_OriginalValue,
		Boolean CustomerDesc_HasBeenChanged,
		String? PrimaryKeyEncryptedForUpdateDeleteIdentification,
		String? PrimaryKeyHashedForUniqueObjectComparison
	)
	{
		this.CustomerTypeID = CustomerTypeID;
		this.CustomerTypeID_OriginalValue = CustomerTypeID_OriginalValue;
		this.CustomerTypeID_HasBeenChanged = CustomerTypeID_HasBeenChanged;
		this.CustomerDesc = CustomerDesc;
		this.CustomerDesc_OriginalValue = CustomerDesc_OriginalValue;
		this.CustomerDesc_HasBeenChanged = CustomerDesc_HasBeenChanged;
		this.PrimaryKeyEncryptedForUpdateDeleteIdentification = PrimaryKeyEncryptedForUpdateDeleteIdentification;
		this.PrimaryKeyHashedForUniqueObjectComparison = PrimaryKeyHashedForUniqueObjectComparison;
	}
	/// <summary>
	/// SQL Column Description: Primary key encrypted value for update and delete identification purposes
	/// </summary>
	public String? PrimaryKeyEncryptedForUpdateDeleteIdentification { get; set; }
	/// <summary>
	/// SQL Column Description: Primary key hashed value for uniue object comparison purposes
	/// </summary>
	public String? PrimaryKeyHashedForUniqueObjectComparison { get; set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CustomerTypeID
	{
		get => _customerTypeID;
		set
		{
			_customerTypeID = value;
			CustomerTypeID_HasBeenChanged = _customerTypeID == CustomerTypeID_OriginalValue ? false : true;
		}
	}
	private String? _customerTypeID;
	public String? CustomerTypeID_OriginalValue  { get; private set; }
	public Boolean CustomerTypeID_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CustomerDesc
	{
		get => _customerDesc;
		set
		{
			_customerDesc = value;
			CustomerDesc_HasBeenChanged = _customerDesc == CustomerDesc_OriginalValue ? false : true;
		}
	}
	private String? _customerDesc;
	public String? CustomerDesc_OriginalValue  { get; private set; }
	public Boolean CustomerDesc_HasBeenChanged  { get; private set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<Northwind_dbo_CustomerCustomerDemo_IR>?FK_CustomerCustomerDemo_RefBy_IR { get; set; } = new HashSet<Northwind_dbo_CustomerCustomerDemo_IR>();
}
