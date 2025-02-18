using LeadManagement.Application.UseCases.Lead.SendEmail;
using LeadManagement.Communication.Requests;
using LeadManagement.Domain.Enums;
using LeadManagement.Domain.Repositories;
using LeadManagement.Domain.Repositories.Leads;
using LeadManagement.Exception.ExceptionBase;

namespace LeadManagement.Application.UseCases.Lead.Accepted;

public class UpdateStatusLeadAcceptedUseCase(ILeadsRepository repository, IUnitOfWork unitOfWork, ISenderEmailUseCase senderEmailUseCase) : IUpdateStatusLeadAcceptedUseCase
{
    public async Task Execute(int leadId)
    {
        var entity = await repository.GetById(leadId);

        if (entity is null)
        {
            throw new NotFoundException("Lead not found");
        }

        entity.Status = Status.Accepted;
        entity.Price = entity.Price > 500 ? entity.Price * 0.9m : entity.Price;

        repository.Update(entity);

        await unitOfWork.Commit();

        var requestSendEmail = new RequestLeadEmail
        {
            Body = $"Your lead was accepted, the price is {entity.Price}",
            Recipient = "vendas@test.com",
            Sender = "vendas@test.com",
            Subject = "Lead Accepted"
        };

        await senderEmailUseCase.Execute(requestSendEmail);

    }

}
