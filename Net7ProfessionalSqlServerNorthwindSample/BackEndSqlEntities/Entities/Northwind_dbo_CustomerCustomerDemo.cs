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
public class Northwind_dbo_CustomerCustomerDemo 
{
	public Northwind_dbo_CustomerCustomerDemo()
	{
	} 
	public Northwind_dbo_CustomerCustomerDemo(
		String customerID_,
		String customerTypeID_
	)
	{
		CustomerID = customerID_;
		CustomerTypeID = customerTypeID_;
	}
	/// <summary>
	/// Primary Key Column
	/// Foreign Key Column
	/// SQL Data Type: nchar Chars: 5 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String CustomerID { get; set; } = null!;
	/// <summary>
	/// Primary Key Column
	/// Foreign Key Column
	/// SQL Data Type: nchar Chars: 10 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String CustomerTypeID { get; set; } = null!;
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	public virtual Northwind_dbo_CustomerDemographics? FK_CustomerCustomerDemo_Ref { get; set; }
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	public virtual Northwind_dbo_Customers? FK_CustomerCustomerDemo_Customers_Ref { get; set; }
}
