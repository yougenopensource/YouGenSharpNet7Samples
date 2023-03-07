/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
using Northwind_BackEndDatabaseClient;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public class Northwind_dbo_Employees_Repository : GenericTableRepository<Northwind_dbo_Employees>, INorthwind_dbo_Employees_Repository
{
    private readonly ILogger<Northwind_dbo_Employees_Repository> _logger;    
    public Northwind_dbo_Employees_Repository
    (
        ILogger<Northwind_dbo_Employees_Repository> logger
        ,Northwind_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<Northwind_dbo_Employees>?> GetByLastName(String lastName_)
	{
		return await _dbContext.Northwind_dbo_Employees!
			.Where(x => x.LastName == lastName_)
			.Include(x => x.FK_Employees_Employees_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Employees>?> GetByEmployeeID(Int32 employeeID_)
	{
		return await _dbContext.Northwind_dbo_Employees!
			.Where(x => x.EmployeeID == employeeID_)
			.Include(x => x.FK_Employees_Employees_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Employees>?> GetByPostalCode(String? postalCode_)
	{
		return await _dbContext.Northwind_dbo_Employees!
			.Where(x => x.PostalCode == postalCode_)
			.Include(x => x.FK_Employees_Employees_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByLastName(String lastName_, Northwind_dbo_Employees entity)
	{
		await _dbContext.Northwind_dbo_Employees!
			.Where(x => x.LastName == lastName_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Employees(){ LastName = entity.LastName, FirstName = entity.FirstName, Title = entity.Title, TitleOfCourtesy = entity.TitleOfCourtesy, BirthDate = entity.BirthDate, HireDate = entity.HireDate, Address = entity.Address, City = entity.City, Region = entity.Region, PostalCode = entity.PostalCode, Country = entity.Country, HomePhone = entity.HomePhone, Extension = entity.Extension, Photo = entity.Photo, Notes = entity.Notes, ReportsTo = entity.ReportsTo, PhotoPath = entity.PhotoPath });
	}
	public async Task UpdateByEmployeeID(Int32 employeeID_, Northwind_dbo_Employees entity)
	{
		await _dbContext.Northwind_dbo_Employees!
			.Where(x => x.EmployeeID == employeeID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Employees(){ LastName = entity.LastName, FirstName = entity.FirstName, Title = entity.Title, TitleOfCourtesy = entity.TitleOfCourtesy, BirthDate = entity.BirthDate, HireDate = entity.HireDate, Address = entity.Address, City = entity.City, Region = entity.Region, PostalCode = entity.PostalCode, Country = entity.Country, HomePhone = entity.HomePhone, Extension = entity.Extension, Photo = entity.Photo, Notes = entity.Notes, ReportsTo = entity.ReportsTo, PhotoPath = entity.PhotoPath });
	}
	public async Task UpdateByPostalCode(String? postalCode_, Northwind_dbo_Employees entity)
	{
		await _dbContext.Northwind_dbo_Employees!
			.Where(x => x.PostalCode == postalCode_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Employees(){ LastName = entity.LastName, FirstName = entity.FirstName, Title = entity.Title, TitleOfCourtesy = entity.TitleOfCourtesy, BirthDate = entity.BirthDate, HireDate = entity.HireDate, Address = entity.Address, City = entity.City, Region = entity.Region, PostalCode = entity.PostalCode, Country = entity.Country, HomePhone = entity.HomePhone, Extension = entity.Extension, Photo = entity.Photo, Notes = entity.Notes, ReportsTo = entity.ReportsTo, PhotoPath = entity.PhotoPath });
	}
	public async Task DeleteByLastName(String lastName_)
	{
		await _dbContext.Northwind_dbo_Employees!
			.Where(x => x.LastName == lastName_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByEmployeeID(Int32 employeeID_)
	{
		await _dbContext.Northwind_dbo_Employees!
			.Where(x => x.EmployeeID == employeeID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByPostalCode(String? postalCode_)
	{
		await _dbContext.Northwind_dbo_Employees!
			.Where(x => x.PostalCode == postalCode_)
			.DeleteFromQueryAsync();
	}
}
