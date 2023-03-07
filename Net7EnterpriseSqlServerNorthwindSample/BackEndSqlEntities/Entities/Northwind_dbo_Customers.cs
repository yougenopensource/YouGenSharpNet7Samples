/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: Table Description: N/A
/// </summary>
public class Northwind_dbo_Customers 
{
	public Northwind_dbo_Customers()
	{
	} 
	public Northwind_dbo_Customers(
		String customerID_,
		String companyName_,
		String? contactName_,
		String? contactTitle_,
		String? address_,
		String? city_,
		String? region_,
		String? postalCode_,
		String? country_,
		String? phone_,
		String? fax_
	)
	{
		CustomerID = customerID_;
		CompanyName = companyName_;
		ContactName = contactName_;
		ContactTitle = contactTitle_;
		Address = address_;
		City = city_;
		Region = region_;
		PostalCode = postalCode_;
		Country = country_;
		Phone = phone_;
		Fax = fax_;
	}
	/// <summary>
	/// Primary Key Column
	/// SQL Data Type: nchar Chars: 5 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String CustomerID { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 40 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String CompanyName { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 30 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ContactName { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 30 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ContactTitle { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 60 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Address { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? City { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Region { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 10 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? PostalCode { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Country { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 24 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Phone { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 24 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Fax { get; set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<Northwind_dbo_CustomerCustomerDemo>?FK_CustomerCustomerDemo_Customers_RefBy { get; set; } = new HashSet<Northwind_dbo_CustomerCustomerDemo>();
	public virtual ICollection<Northwind_dbo_Orders>?FK_Orders_Customers_RefBy { get; set; } = new HashSet<Northwind_dbo_Orders>();
}
