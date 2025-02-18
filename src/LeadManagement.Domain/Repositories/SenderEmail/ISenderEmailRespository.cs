using LeadManagement.Domain.Entities;

namespace LeadManagement.Domain.Repositories.SenderEmail;

public interface ISenderEmailRespository
{
    void SenderEmail(LeadEmailEntity request);
}