using LeadManagement.Communication.Requests;
using LeadManagement.Domain.Entities;
using LeadManagement.Domain.Enums;
using LeadManagement.Domain.Repositories;
using LeadManagement.Domain.Repositories.Leads;
using LeadManagement.Exception.ExceptionBase;


namespace LeadManagement.Application.UseCases.Lead.Invited.Register;

public class RegisterLeadUseCase(ILeadsRepository repository, IUnitOfWork unitOfWork) : IRegisterLeadUseCase
{
    private readonly ILeadsRepository _repository = repository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task Execute(RequestLeadJson request)
    {
        Validate(request);

        var entity = new LeadEntity
        {
            ContactFirstName = request.ContactFirstName,
            ContactFullName = request.ContactFullName,
            PhoneNumber = request.PhoneNumber,
            Email = request.Email,
            Suburb = request.Suburb,
            Category = request.Category,
            Description = request.Description,
            Price = request.Price,
            DateCreated = DateTime.Now,
            Status = Status.Invited,
        };
        
        await _repository.Add(entity);
        await _unitOfWork.Commit();
    }
    
    private void Validate(RequestLeadJson request)
    {
        var validator = new RegisterLeadValidator();
        var result = validator.Validate(request);

        if (result.IsValid == false)
        {
            var errorMessages = result.Errors.Select(e => e.ErrorMessage).ToList();
            throw new ErrorOnValidationException(errorMessages);
        }
    }
}