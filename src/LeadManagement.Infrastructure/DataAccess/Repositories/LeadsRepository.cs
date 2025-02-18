using LeadManagement.Domain.Entities;
using LeadManagement.Domain.Enums;
using LeadManagement.Domain.Repositories.Leads;
using Microsoft.EntityFrameworkCore;

namespace LeadManagement.Infrastructure.DataAccess.Repositories;

internal class LeadsRepository(LeadManagementDbContext dbContext) : ILeadsRepository
{
    public async Task Add(LeadEntity entity)
    {
        await dbContext.Leads.AddAsync(entity);
    }

    public async Task<LeadEntity?> GetById(int leadId)
    {
        return await dbContext.Leads.FirstOrDefaultAsync(lead => lead.Id == leadId);
    }

    public async Task<List<LeadEntity>> GetAllLeadsInvited(string status)
    {

        var statusEnum = Enum.Parse<Status>(status);

        return await dbContext.Leads
            .Where(lead => lead.Status == statusEnum)
            .OrderByDescending(lead => lead.DateCreated)
            .ToListAsync();

    }

    public void Update(LeadEntity entity)
    {
        dbContext.Leads.Update(entity);
    }

}