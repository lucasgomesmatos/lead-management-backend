using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadManagement.Communication.Requests;

public class RequestLeadJson
{
    public string ContactFirstName { get; set; }
    public string ContactFullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Suburb { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
