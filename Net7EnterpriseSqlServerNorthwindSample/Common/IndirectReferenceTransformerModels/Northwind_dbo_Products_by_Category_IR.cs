/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
public class Northwind_dbo_Products_by_Category_IR
{
	public Northwind_dbo_Products_by_Category_IR() 
	{
	} 
	public Northwind_dbo_Products_by_Category_IR(
		String? categoryName_,
		String? productName_,
		String? quantityPerUnit_,
		Int16? unitsInStock_,
		Boolean? discontinued_
	)
	{
		_categoryName = categoryName_;
		CategoryName_OriginalValue = categoryName_;
		_productName = productName_;
		ProductName_OriginalValue = productName_;
		_quantityPerUnit = quantityPerUnit_;
		QuantityPerUnit_OriginalValue = quantityPerUnit_;
		_unitsInStock = unitsInStock_;
		UnitsInStock_OriginalValue = unitsInStock_;
		_discontinued = discontinued_;
		Discontinued_OriginalValue = discontinued_;
	}
	[JsonConstructor]
	public Northwind_dbo_Products_by_Category_IR(
		String? CategoryName,
		String? CategoryName_OriginalValue,
		Boolean CategoryName_HasBeenChanged,
		String? ProductName,
		String? ProductName_OriginalValue,
		Boolean ProductName_HasBeenChanged,
		String? QuantityPerUnit,
		String? QuantityPerUnit_OriginalValue,
		Boolean QuantityPerUnit_HasBeenChanged,
		Int16? UnitsInStock,
		Int16? UnitsInStock_OriginalValue,
		Boolean UnitsInStock_HasBeenChanged,
		Boolean? Discontinued,
		Boolean? Discontinued_OriginalValue,
		Boolean Discontinued_HasBeenChanged
	)
	{
		this.CategoryName = CategoryName;
		this.CategoryName_OriginalValue = CategoryName_OriginalValue;
		this.CategoryName_HasBeenChanged = CategoryName_HasBeenChanged;
		this.ProductName = ProductName;
		this.ProductName_OriginalValue = ProductName_OriginalValue;
		this.ProductName_HasBeenChanged = ProductName_HasBeenChanged;
		this.QuantityPerUnit = QuantityPerUnit;
		this.QuantityPerUnit_OriginalValue = QuantityPerUnit_OriginalValue;
		this.QuantityPerUnit_HasBeenChanged = QuantityPerUnit_HasBeenChanged;
		this.UnitsInStock = UnitsInStock;
		this.UnitsInStock_OriginalValue = UnitsInStock_OriginalValue;
		this.UnitsInStock_HasBeenChanged = UnitsInStock_HasBeenChanged;
		this.Discontinued = Discontinued;
		this.Discontinued_OriginalValue = Discontinued_OriginalValue;
		this.Discontinued_HasBeenChanged = Discontinued_HasBeenChanged;
	}
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CategoryName
	{
		get => _categoryName;
		set
		{
			_categoryName = value;
			CategoryName_HasBeenChanged = _categoryName == CategoryName_OriginalValue ? false : true;
		}
	}
	private String? _categoryName;
	public String? CategoryName_OriginalValue { get; private set; }
	public Boolean CategoryName_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? ProductName
	{
		get => _productName;
		set
		{
			_productName = value;
			ProductName_HasBeenChanged = _productName == ProductName_OriginalValue ? false : true;
		}
	}
	private String? _productName;
	public String? ProductName_OriginalValue { get; private set; }
	public Boolean ProductName_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? QuantityPerUnit
	{
		get => _quantityPerUnit;
		set
		{
			_quantityPerUnit = value;
			QuantityPerUnit_HasBeenChanged = _quantityPerUnit == QuantityPerUnit_OriginalValue ? false : true;
		}
	}
	private String? _quantityPerUnit;
	public String? QuantityPerUnit_OriginalValue { get; private set; }
	public Boolean QuantityPerUnit_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Int16? UnitsInStock
	{
		get => _unitsInStock;
		set
		{
			_unitsInStock = value;
			UnitsInStock_HasBeenChanged = _unitsInStock == UnitsInStock_OriginalValue ? false : true;
		}
	}
	private Int16? _unitsInStock;
	public Int16? UnitsInStock_OriginalValue { get; private set; }
	public Boolean UnitsInStock_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Boolean? Discontinued
	{
		get => _discontinued;
		set
		{
			_discontinued = value;
			Discontinued_HasBeenChanged = _discontinued == Discontinued_OriginalValue ? false : true;
		}
	}
	private Boolean? _discontinued;
	public Boolean? Discontinued_OriginalValue { get; private set; }
	public Boolean Discontinued_HasBeenChanged { get; private set; }
}
