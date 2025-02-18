using LeadManagement.Communication.Requests;
using LeadManagement.Domain.Entities;
using LeadManagement.Domain.Repositories.SenderEmail;

namespace LeadManagement.Application.UseCases.Lead.SendEmail;

public class SenderEmailUseCase(ISenderEmailRespository respository) : ISenderEmailUseCase
{
    public async Task Execute(RequestLeadEmail leadEmail)
    {
        var entity = new LeadEmailEntity
        {
            Recipient = leadEmail.Recipient,
            Subject = leadEmail.Subject,
            Sender = leadEmail.Sender,
            Body = leadEmail.Body
        };

        respository.SenderEmail(entity);
    }
}