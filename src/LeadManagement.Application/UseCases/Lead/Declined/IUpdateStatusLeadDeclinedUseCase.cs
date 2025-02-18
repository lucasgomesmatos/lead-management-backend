namespace LeadManagement.Application.UseCases.Lead.Declined;

public interface IUpdateStatusLeadDeclinedUseCase
{
    Task Execute(int leadId);
}