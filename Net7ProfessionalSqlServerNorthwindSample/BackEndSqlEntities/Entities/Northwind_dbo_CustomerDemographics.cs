/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: Table Description: N/A
/// </summary>
public class Northwind_dbo_CustomerDemographics 
{
	public Northwind_dbo_CustomerDemographics()
	{
	} 
	public Northwind_dbo_CustomerDemographics(
		String customerTypeID_,
		String? customerDesc_
	)
	{
		CustomerTypeID = customerTypeID_;
		CustomerDesc = customerDesc_;
	}
	/// <summary>
	/// Primary Key Column
	/// SQL Data Type: nchar Chars: 10 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String CustomerTypeID { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: ntext Chars: 1073741823 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? CustomerDesc { get; set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<Northwind_dbo_CustomerCustomerDemo>?FK_CustomerCustomerDemo_RefBy { get; set; } = new HashSet<Northwind_dbo_CustomerCustomerDemo>();
}
