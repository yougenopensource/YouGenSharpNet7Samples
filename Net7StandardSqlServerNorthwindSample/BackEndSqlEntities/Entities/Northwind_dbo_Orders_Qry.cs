/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200434 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
// For reads only
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: View Description: N/A
/// </summary>
public class Northwind_dbo_Orders_Qry 
{
	public Northwind_dbo_Orders_Qry()
	{
	} 
	/// <summary>
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32 OrderID { get; set; }
	/// <summary>
	/// SQL Data Type: nchar Chars: 5 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? CustomerID { get; set; }
	/// <summary>
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32? EmployeeID { get; set; }
	/// <summary>
	/// SQL Data Type: datetime 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual DateTime? OrderDate { get; set; }
	/// <summary>
	/// SQL Data Type: datetime 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual DateTime? RequiredDate { get; set; }
	/// <summary>
	/// SQL Data Type: datetime 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual DateTime? ShippedDate { get; set; }
	/// <summary>
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32? ShipVia { get; set; }
	/// <summary>
	/// SQL Data Type: money Precision: 19 Scale: 4 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Decimal? Freight { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 40 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ShipName { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 60 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ShipAddress { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ShipCity { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ShipRegion { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 10 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ShipPostalCode { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? ShipCountry { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 40 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String CompanyName { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 60 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Address { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? City { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Region { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 10 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? PostalCode { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Country { get; set; }
}
