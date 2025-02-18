using LeadManagement.Communication.Requests;

namespace LeadManagement.Application.UseCases.Lead.SendEmail;

public interface ISenderEmailUseCase
{
    Task Execute(RequestLeadEmail leadEmail);  
} 
