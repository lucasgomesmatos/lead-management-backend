namespace LeadManagement.Application.UseCases.Lead.Accepted;

public interface IUpdateStatusLeadAcceptedUseCase
{
    Task Execute(int leadId);
}
