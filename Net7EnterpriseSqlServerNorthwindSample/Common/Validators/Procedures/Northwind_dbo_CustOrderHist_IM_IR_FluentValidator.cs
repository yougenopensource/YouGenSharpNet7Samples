/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using FluentValidation;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_Common.Validators;
public class Northwind_dbo_CustOrderHist_IM_IR_FluentValidator : AbstractValidator<Northwind_dbo_CustOrderHist_IM_IR>, IFluentValidator_Base
{
    public Northwind_dbo_CustOrderHist_IM_IR_FluentValidator()
    {
			RuleFor(x => x.CustomerID)
				.NotEmpty();
    }
    public async Task<IEnumerable<String>> ValidateValue(Object model, String propertyName)
    {
        var result = await ValidateAsync(ValidationContext<Northwind_dbo_CustOrderHist_IM_IR>.CreateWithOptions((Northwind_dbo_CustOrderHist_IM_IR)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<String>();
        return result.Errors.Select(e => e.ErrorMessage);
    }
    public async Task ValidateValueAndThrow(Object model, String propertyName)
    {
        var result = await ValidateValue(model, propertyName);
        if (result.Any())
#if DEBUG
            throw new HttpRequestException(String.Join(Environment.NewLine, result), null, System.Net.HttpStatusCode.BadRequest);
#else
            throw new HttpRequestException("Model property validation failed", null, System.Net.HttpStatusCode.BadRequest);
#endif
    }
    public async Task ValidateModelAndThrow(Object model)
    {
        try
        {
            await this.ValidateAndThrowAsync((Northwind_dbo_CustOrderHist_IM_IR)model);
        }
        catch (Exception ex)
        {
#if DEBUG
            throw new HttpRequestException(ex.Message, ex, System.Net.HttpStatusCode.BadRequest);
#else
            throw new HttpRequestException("Model validation failed", null, System.Net.HttpStatusCode.BadRequest);
#endif
        }
    }
}
