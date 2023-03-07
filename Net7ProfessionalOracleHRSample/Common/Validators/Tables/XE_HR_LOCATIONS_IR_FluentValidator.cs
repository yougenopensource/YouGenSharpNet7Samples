/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using FluentValidation;
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_Common.Validators;
public class XE_HR_LOCATIONS_IR_FluentValidator_Base : AbstractValidator<XE_HR_LOCATIONS_IR>, IFluentValidator_Base
{
    public async Task<IEnumerable<String>> ValidateValue(Object model, String propertyName)
    {
        var result = await ValidateAsync(ValidationContext<XE_HR_LOCATIONS_IR>.CreateWithOptions((XE_HR_LOCATIONS_IR)model, x => x.IncludeProperties(propertyName)));
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
            await this.ValidateAndThrowAsync((XE_HR_LOCATIONS_IR)model);
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
public class XE_HR_LOCATIONS_IR_FluentValidator_Create : XE_HR_LOCATIONS_IR_FluentValidator_Base
{
    public XE_HR_LOCATIONS_IR_FluentValidator_Create()
    {
			// RuleFor(x => x.LOCATION_ID_IR)
				// .NotEmpty();
			RuleFor(x => x.STREET_ADDRESS)
				.NotEmpty();
			RuleFor(x => x.POSTAL_CODE)
				.NotEmpty();
			// RuleFor(x => x.CITY)
				// .NotEmpty();
			RuleFor(x => x.STATE_PROVINCE)
				.NotEmpty();
			RuleFor(x => x.COUNTRY_ID)
				.NotEmpty();
    }
}
public class XE_HR_LOCATIONS_IR_FluentValidator_Read : XE_HR_LOCATIONS_IR_FluentValidator_Base
{
    public XE_HR_LOCATIONS_IR_FluentValidator_Read()
    {
			// RuleFor(x => x.LOCATION_ID_IR)
				// .NotEmpty();
			// RuleFor(x => x.STREET_ADDRESS)
				// .NotEmpty();
			// RuleFor(x => x.POSTAL_CODE)
				// .NotEmpty();
			// RuleFor(x => x.CITY)
				// .NotEmpty();
			// RuleFor(x => x.STATE_PROVINCE)
				// .NotEmpty();
			// RuleFor(x => x.COUNTRY_ID)
				// .NotEmpty();
    }
}
public class XE_HR_LOCATIONS_IR_FluentValidator_Update : XE_HR_LOCATIONS_IR_FluentValidator_Base
{
    public XE_HR_LOCATIONS_IR_FluentValidator_Update()
    {
			// RuleFor(x => x.LOCATION_ID_IR)
				// .NotEmpty();
			RuleFor(x => x.STREET_ADDRESS)
				.NotEmpty();
			RuleFor(x => x.POSTAL_CODE)
				.NotEmpty();
			// RuleFor(x => x.CITY)
				// .NotEmpty();
			RuleFor(x => x.STATE_PROVINCE)
				.NotEmpty();
			RuleFor(x => x.COUNTRY_ID)
				.NotEmpty();
    }
}
public class XE_HR_LOCATIONS_IR_FluentValidator_Delete : XE_HR_LOCATIONS_IR_FluentValidator_Base
{
    public XE_HR_LOCATIONS_IR_FluentValidator_Delete()
    {
			 RuleFor(x => x.LOCATION_ID_IR)
				 .NotEmpty();
    }
}
