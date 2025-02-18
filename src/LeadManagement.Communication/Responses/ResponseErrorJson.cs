namespace LeadManagement.Communication.Responses;

public class ResponseErrorJson
{
    public List<string> Errors { get; set; }

    public ResponseErrorJson(string message)
    {
        Errors = [message];
    }

    public ResponseErrorJson(List<string> errors)
    {
        Errors = errors;
    }
}
