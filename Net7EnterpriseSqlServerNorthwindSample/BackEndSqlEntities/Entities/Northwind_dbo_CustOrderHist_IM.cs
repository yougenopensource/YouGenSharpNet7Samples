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
/// SQL Entity Description: Model Description: Stored Procedure Input Model Parameters
/// </summary>
public class Northwind_dbo_CustOrderHist_IM 
{
	public Northwind_dbo_CustOrderHist_IM()
	{
	} 
	public Northwind_dbo_CustOrderHist_IM(
		String? customerID_
	)
	{
		CustomerID = customerID_;
	}
	/// <summary>
	/// SQL Data Type: nchar Chars: 5 Precision: 0 Scale: 0 
	/// </summary>
	public virtual String? CustomerID { get; set; }
}
