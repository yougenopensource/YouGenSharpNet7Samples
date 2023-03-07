/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
// For reads only
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Northwind_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Indirect Referenced Model Description: N/A
/// </summary>
public class Northwind_dbo_Summary_of_Sales_by_Year_IR
{
	public Northwind_dbo_Summary_of_Sales_by_Year_IR() 
	{
	} 
	public Northwind_dbo_Summary_of_Sales_by_Year_IR(
		DateTime? shippedDate_,
		String? orderID_IR_,
		Decimal? subtotal_
	)
	{
		_shippedDate = shippedDate_;
		ShippedDate_OriginalValue = shippedDate_;
		_orderID_IR = orderID_IR_;
		OrderID_IR_OriginalValue = orderID_IR_;
		_subtotal = subtotal_;
		Subtotal_OriginalValue = subtotal_;
	}
	[JsonConstructor]
	public Northwind_dbo_Summary_of_Sales_by_Year_IR(
		DateTime? ShippedDate,
		DateTime? ShippedDate_OriginalValue,
		Boolean ShippedDate_HasBeenChanged,
		String? OrderID_IR,
		String? OrderID_IR_OriginalValue,
		Boolean OrderID_IR_HasBeenChanged,
		Decimal? Subtotal,
		Decimal? Subtotal_OriginalValue,
		Boolean Subtotal_HasBeenChanged
	)
	{
		this.ShippedDate = ShippedDate;
		this.ShippedDate_OriginalValue = ShippedDate_OriginalValue;
		this.ShippedDate_HasBeenChanged = ShippedDate_HasBeenChanged;
		this.OrderID_IR = OrderID_IR;
		this.OrderID_IR_OriginalValue = OrderID_IR_OriginalValue;
		this.OrderID_IR_HasBeenChanged = OrderID_IR_HasBeenChanged;
		this.Subtotal = Subtotal;
		this.Subtotal_OriginalValue = Subtotal_OriginalValue;
		this.Subtotal_HasBeenChanged = Subtotal_HasBeenChanged;
	}
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public DateTime? ShippedDate
	{
		get => _shippedDate;
		set
		{
			_shippedDate = value;
			ShippedDate_HasBeenChanged = _shippedDate == ShippedDate_OriginalValue ? false : true;
		}
	}
	private DateTime? _shippedDate;
	public DateTime? ShippedDate_OriginalValue { get; private set; }
	public Boolean ShippedDate_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? OrderID_IR
	{
		get => _orderID_IR;
		set
		{
			_orderID_IR = value;
			OrderID_IR_HasBeenChanged = _orderID_IR == OrderID_IR_OriginalValue ? false : true;
		}
	}
	private String? _orderID_IR;
	public String? OrderID_IR_OriginalValue { get; private set; }
	public Boolean OrderID_IR_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Decimal? Subtotal
	{
		get => _subtotal;
		set
		{
			_subtotal = value;
			Subtotal_HasBeenChanged = _subtotal == Subtotal_OriginalValue ? false : true;
		}
	}
	private Decimal? _subtotal;
	public Decimal? Subtotal_OriginalValue { get; private set; }
	public Boolean Subtotal_HasBeenChanged { get; private set; }
}
