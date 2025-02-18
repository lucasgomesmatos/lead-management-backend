using LeadManagement.Domain.Entities;
using LeadManagement.Domain.Repositories.SenderEmail;

namespace LeadManagement.Infrastructure.DataAccess.Email;

public class MailKitEmailService: ISenderEmailRespository
{
    public void SenderEmail(LeadEmailEntity request)
    {
        Console.WriteLine($"Sending email to {request.Recipient} from {request.Sender} with subject {request.Subject}");
    }
}