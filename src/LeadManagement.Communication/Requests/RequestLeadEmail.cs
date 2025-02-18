namespace LeadManagement.Communication.Requests;

public class RequestLeadEmail
{
    public string Sender { get; set; }
    public string Recipient { get; set; }

    public string Subject { get; set; }

    public string Body { get; set; }

}
