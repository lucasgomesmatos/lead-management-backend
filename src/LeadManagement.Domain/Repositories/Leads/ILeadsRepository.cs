using LeadManagement.Domain.Entities;

namespace LeadManagement.Domain.Repositories.Leads;

public interface ILeadsRepository
{
    Task Add(LeadEntity entity);
    Task<LeadEntity?> GetById(int leadId);
    Task<List<LeadEntity>> GetAllLeadsInvited(string status);
    void Update(LeadEntity entity);
}