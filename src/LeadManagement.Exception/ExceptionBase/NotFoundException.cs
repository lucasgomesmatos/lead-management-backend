using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadManagement.Exception.ExceptionBase;

public class NotFoundException(string message) : LeadManagementException
{
    public string Message { get; set; } = message;
}
