/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
using Northwind_BackEndDatabaseClient;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public class Northwind_dbo_Products_Repository : GenericTableRepository<Northwind_dbo_Products>, INorthwind_dbo_Products_Repository
{
    private readonly ILogger<Northwind_dbo_Products_Repository> _logger;    
    public Northwind_dbo_Products_Repository
    (
        ILogger<Northwind_dbo_Products_Repository> logger
        ,Northwind_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<Northwind_dbo_Products>?> GetByCategoryID(Int32? categoryID_)
	{
		return await _dbContext.Northwind_dbo_Products!
			.Where(x => x.CategoryID == categoryID_)
			.Include(x => x.FK_Products_Categories_Ref)
			.Include(x => x.FK_Products_Suppliers_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Products>?> GetByProductID(Int32 productID_)
	{
		return await _dbContext.Northwind_dbo_Products!
			.Where(x => x.ProductID == productID_)
			.Include(x => x.FK_Products_Categories_Ref)
			.Include(x => x.FK_Products_Suppliers_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Products>?> GetByProductName(String productName_)
	{
		return await _dbContext.Northwind_dbo_Products!
			.Where(x => x.ProductName == productName_)
			.Include(x => x.FK_Products_Categories_Ref)
			.Include(x => x.FK_Products_Suppliers_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Products>?> GetBySupplierID(Int32? supplierID_)
	{
		return await _dbContext.Northwind_dbo_Products!
			.Where(x => x.SupplierID == supplierID_)
			.Include(x => x.FK_Products_Categories_Ref)
			.Include(x => x.FK_Products_Suppliers_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByCategoryID(Int32? categoryID_, Northwind_dbo_Products entity)
	{
		await _dbContext.Northwind_dbo_Products!
			.Where(x => x.CategoryID == categoryID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Products(){ ProductName = entity.ProductName, SupplierID = entity.SupplierID, CategoryID = entity.CategoryID, QuantityPerUnit = entity.QuantityPerUnit, UnitPrice = entity.UnitPrice, UnitsInStock = entity.UnitsInStock, UnitsOnOrder = entity.UnitsOnOrder, ReorderLevel = entity.ReorderLevel, Discontinued = entity.Discontinued });
	}
	public async Task UpdateByProductID(Int32 productID_, Northwind_dbo_Products entity)
	{
		await _dbContext.Northwind_dbo_Products!
			.Where(x => x.ProductID == productID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Products(){ ProductName = entity.ProductName, SupplierID = entity.SupplierID, CategoryID = entity.CategoryID, QuantityPerUnit = entity.QuantityPerUnit, UnitPrice = entity.UnitPrice, UnitsInStock = entity.UnitsInStock, UnitsOnOrder = entity.UnitsOnOrder, ReorderLevel = entity.ReorderLevel, Discontinued = entity.Discontinued });
	}
	public async Task UpdateByProductName(String productName_, Northwind_dbo_Products entity)
	{
		await _dbContext.Northwind_dbo_Products!
			.Where(x => x.ProductName == productName_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Products(){ ProductName = entity.ProductName, SupplierID = entity.SupplierID, CategoryID = entity.CategoryID, QuantityPerUnit = entity.QuantityPerUnit, UnitPrice = entity.UnitPrice, UnitsInStock = entity.UnitsInStock, UnitsOnOrder = entity.UnitsOnOrder, ReorderLevel = entity.ReorderLevel, Discontinued = entity.Discontinued });
	}
	public async Task UpdateBySupplierID(Int32? supplierID_, Northwind_dbo_Products entity)
	{
		await _dbContext.Northwind_dbo_Products!
			.Where(x => x.SupplierID == supplierID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Products(){ ProductName = entity.ProductName, SupplierID = entity.SupplierID, CategoryID = entity.CategoryID, QuantityPerUnit = entity.QuantityPerUnit, UnitPrice = entity.UnitPrice, UnitsInStock = entity.UnitsInStock, UnitsOnOrder = entity.UnitsOnOrder, ReorderLevel = entity.ReorderLevel, Discontinued = entity.Discontinued });
	}
	public async Task DeleteByCategoryID(Int32? categoryID_)
	{
		await _dbContext.Northwind_dbo_Products!
			.Where(x => x.CategoryID == categoryID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByProductID(Int32 productID_)
	{
		await _dbContext.Northwind_dbo_Products!
			.Where(x => x.ProductID == productID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByProductName(String productName_)
	{
		await _dbContext.Northwind_dbo_Products!
			.Where(x => x.ProductName == productName_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteBySupplierID(Int32? supplierID_)
	{
		await _dbContext.Northwind_dbo_Products!
			.Where(x => x.SupplierID == supplierID_)
			.DeleteFromQueryAsync();
	}
}
