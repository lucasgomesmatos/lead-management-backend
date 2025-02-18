namespace LeadManagement.Communication.Responses;

public class ResponseInvitedLeadJson
{
    public int Id { get; set; }
    public string ContactFirstName { get; set; } = string.Empty;
    public string ContactFullName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime DateCreated { get; set; }
    public string Suburb { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }

}

