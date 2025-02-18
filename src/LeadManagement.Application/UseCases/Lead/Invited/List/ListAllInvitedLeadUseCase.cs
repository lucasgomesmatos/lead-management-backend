using LeadManagement.Communication.Responses;
using LeadManagement.Domain.Enums;
using LeadManagement.Domain.Repositories.Leads;
using LeadManagement.Exception.ExceptionBase;

namespace LeadManagement.Application.UseCases.Lead.Invited.List;

public class ListAllInvitedLeadUseCase: IListAllInvitedLeadUseCase
{
    private readonly ILeadsRepository _repository;

    public ListAllInvitedLeadUseCase(ILeadsRepository repository)
    {
        _repository = repository;
    }


    public async Task<List<ResponseInvitedLeadJson>> Execute(string status)
    {
        var validade = Enum.TryParse<Status>(status, out _);

        if (!validade) {

            throw new ErrorOnValidationException(["Status is invalid "]);
        }

        var list = new List<ResponseInvitedLeadJson>();
        var leads = await _repository.GetAllLeadsInvited(status);

        foreach (var item in leads)
        {
            list.Add(new ResponseInvitedLeadJson { 
            
                Id = item.Id,
                Category = item.Category,
                ContactFullName = item.ContactFullName,
                ContactFirstName = item.ContactFirstName,
                DateCreated = item.DateCreated,
                Description = item.Description,
                Price = item.Price,
                Suburb = item.Suburb,
                Email = item.Email,
                PhoneNumber = item.PhoneNumber   
            });
        }

        return list;
    }

}