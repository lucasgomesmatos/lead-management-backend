using LeadManagement.Application.UseCases.Lead.Accepted;
using LeadManagement.Application.UseCases.Lead.Declined;
using LeadManagement.Application.UseCases.Lead.Invited.List;
using LeadManagement.Application.UseCases.Lead.Invited.Register;
using LeadManagement.Application.UseCases.Lead.SendEmail;
using Microsoft.Extensions.DependencyInjection;

namespace LeadManagement.Application;

public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IRegisterLeadUseCase, RegisterLeadUseCase>();
        services.AddScoped<IListAllInvitedLeadUseCase, ListAllInvitedLeadUseCase>();
        services.AddScoped<IUpdateStatusLeadAcceptedUseCase, UpdateStatusLeadAcceptedUseCase>();
        services.AddScoped<IUpdateStatusLeadDeclinedUseCase, UpdateStatusLeadDeclinedUseCase>();
        services.AddScoped< ISenderEmailUseCase, SenderEmailUseCase>();
    }
}