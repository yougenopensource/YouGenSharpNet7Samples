/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200434 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: Table Description: N/A
/// </summary>
public class Northwind_dbo_Orders 
{
	public Northwind_dbo_Orders()
	{
	} 
	/// <summary>
	/// Identity Column
	/// Primary Key Column
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32 OrderID { get; set; }
	/// <summary>
	/// Foreign Key Column
	/// SQL Data Type: nchar Chars: 5 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? CustomerID { get; set; }
	/// <summary>
	/// Foreign Key Column
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32? EmployeeID { get; set; }
	/// <summary>
	/// SQL Data Type: datetime 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual DateTime? OrderDate { get; set; }
	/// <summary>
	/// SQL Data Type: datetime 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual DateTime? RequiredDate { get; set; }
	/// <summary>
	/// SQL Data Type: datetime 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual DateTime? ShippedDate { get; set; }
	/// <summary>
	/// Foreign Key Column
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32? ShipVia { get; set; }
	/// <summary>
	/// SQL Data Type: money Precision: 19 Scale: 4 
	/// SQL Default Value: ((0))
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Decimal? Freight { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 40 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ShipName { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 60 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ShipAddress { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ShipCity { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ShipRegion { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 10 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ShipPostalCode { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ShipCountry { get; set; }
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	public virtual Northwind_dbo_Customers? FK_Orders_Customers_Ref { get; set; }
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	public virtual Northwind_dbo_Employees? FK_Orders_Employees_Ref { get; set; }
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	public virtual Northwind_dbo_Shippers? FK_Orders_Shippers_Ref { get; set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<Northwind_dbo_Order_Details>?FK_Order_Details_Orders_RefBy { get; set; } = new HashSet<Northwind_dbo_Order_Details>();
}
