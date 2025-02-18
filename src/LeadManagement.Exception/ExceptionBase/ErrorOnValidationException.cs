using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadManagement.Exception.ExceptionBase;

public class ErrorOnValidationException : LeadManagementException
{

    public List<string> Errors { get; set; }

    public ErrorOnValidationException(List<string> errosMessages)
    {
        Errors = errosMessages;
    }
}
