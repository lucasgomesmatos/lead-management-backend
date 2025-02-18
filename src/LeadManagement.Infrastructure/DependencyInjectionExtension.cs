using LeadManagement.Domain.Repositories;
using LeadManagement.Domain.Repositories.Leads;
using LeadManagement.Domain.Repositories.SenderEmail;
using LeadManagement.Infrastructure.DataAccess;
using LeadManagement.Infrastructure.DataAccess.Email;
using LeadManagement.Infrastructure.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LeadManagement.Infrastructure;

public static class DependencyInjectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDbContext(services, configuration);
        AddRepositories(services);
        AddEmailService(services);
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ILeadsRepository, LeadsRepository>();
    }

    private static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<LeadManagementDbContext>(config => config.UseSqlServer(connectionString));
    }
    
    
    private static void AddEmailService(this IServiceCollection services)
    {
        services.AddScoped<ISenderEmailRespository, MailKitEmailService>();
    }
   
}