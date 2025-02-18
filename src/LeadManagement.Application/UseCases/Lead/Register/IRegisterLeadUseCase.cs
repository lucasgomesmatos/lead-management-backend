using LeadManagement.Communication.Requests;

namespace LeadManagement.Application.UseCases.Lead.Invited.Register;

public interface IRegisterLeadUseCase
{
    Task Execute(RequestLeadJson request);
}