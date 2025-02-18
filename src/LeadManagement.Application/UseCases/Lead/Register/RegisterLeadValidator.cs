using FluentValidation;
using LeadManagement.Communication.Requests;

namespace LeadManagement.Application.UseCases.Lead.Invited.Register;

public class RegisterLeadValidator: AbstractValidator<RequestLeadJson>
{
    public RegisterLeadValidator()
    {
        RuleFor(lead => lead.ContactFirstName).NotEmpty().WithMessage("ContactFirstName is required");
        RuleFor(lead => lead.ContactFullName).NotEmpty().WithMessage("ContactFullName is required");
        RuleFor(lead => lead.PhoneNumber).NotEmpty().WithMessage("PhoneNumber is required");
        RuleFor(lead => lead.Email).EmailAddress().WithMessage("Email is required");
        RuleFor(lead => lead.Suburb).NotEmpty().WithMessage("Suburb is required");
        RuleFor(lead => lead.Category).NotEmpty().WithMessage("Category is required");
        RuleFor(lead => lead.Description).NotEmpty().WithMessage("Description is required");
        RuleFor(lead => lead.Price).NotEmpty().WithMessage("Price is required");
    }
}
