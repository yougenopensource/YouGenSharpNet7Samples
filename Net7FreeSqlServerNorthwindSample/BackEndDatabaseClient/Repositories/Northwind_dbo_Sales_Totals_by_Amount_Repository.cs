/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200257 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public class Northwind_dbo_Sales_Totals_by_Amount_Repository : GenericRepository<Northwind_dbo_Sales_Totals_by_Amount>, INorthwind_dbo_Sales_Totals_by_Amount_Repository
{
    private readonly ILogger<Northwind_dbo_Sales_Totals_by_Amount_Repository> _logger;    
    public Northwind_dbo_Sales_Totals_by_Amount_Repository
    (
        ILogger<Northwind_dbo_Sales_Totals_by_Amount_Repository> logger
        ,Northwind_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
}
