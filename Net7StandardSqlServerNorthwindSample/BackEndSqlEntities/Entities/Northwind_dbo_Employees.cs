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
public class Northwind_dbo_Employees 
{
	public Northwind_dbo_Employees()
	{
	} 
	/// <summary>
	/// Identity Column
	/// Primary Key Column
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32 EmployeeID { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 20 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String LastName { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 10 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String FirstName { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 30 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Title { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 25 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? TitleOfCourtesy { get; set; }
	/// <summary>
	/// SQL Data Type: datetime 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual DateTime? BirthDate { get; set; }
	/// <summary>
	/// SQL Data Type: datetime 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual DateTime? HireDate { get; set; }
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
	public virtual String? HomePhone { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 4 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Extension { get; set; }
	/// <summary>
	/// SQL Data Type: image Chars: 2147483647 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Byte[]? Photo { get; set; }
	/// <summary>
	/// SQL Data Type: ntext Chars: 1073741823 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Notes { get; set; }
	/// <summary>
	/// Foreign Key Column
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32? ReportsTo { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 255 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? PhotoPath { get; set; }
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	public virtual Northwind_dbo_Employees? FK_Employees_Employees_Ref { get; set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<Northwind_dbo_Employees>?FK_Employees_Employees_RefBy { get; set; } = new HashSet<Northwind_dbo_Employees>();
	public virtual ICollection<Northwind_dbo_EmployeeTerritories>?FK_EmployeeTerritories_Employees_RefBy { get; set; } = new HashSet<Northwind_dbo_EmployeeTerritories>();
	public virtual ICollection<Northwind_dbo_Orders>?FK_Orders_Employees_RefBy { get; set; } = new HashSet<Northwind_dbo_Orders>();
}
