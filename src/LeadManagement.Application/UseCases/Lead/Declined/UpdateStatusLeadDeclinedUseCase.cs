using LeadManagement.Domain.Enums;
using LeadManagement.Domain.Repositories;
using LeadManagement.Domain.Repositories.Leads;
using LeadManagement.Exception.ExceptionBase;

namespace LeadManagement.Application.UseCases.Lead.Declined;

public class UpdateStatusLeadDeclinedUseCase(ILeadsRepository repository, IUnitOfWork unitOfWork) : IUpdateStatusLeadDeclinedUseCase
{
    public async Task Execute(int leadId)
    {
        var entity = await repository.GetById(leadId);

        if (entity is null)
        {
            throw new NotFoundException("Lead not found");
        }

        entity.Status = Status.Declined;

        repository.Update(entity);

        await unitOfWork.Commit();

    }
}