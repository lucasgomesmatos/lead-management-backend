using LeadManagement.Communication.Requests;
using LeadManagement.Communication.Responses;

namespace LeadManagement.Application.UseCases.Lead.Invited.List;

public interface IListAllInvitedLeadUseCase
{
    Task<List<ResponseInvitedLeadJson>> Execute(string status);
}
