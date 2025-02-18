using LeadManagement.Communication.Responses;
using LeadManagement.Exception.ExceptionBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LeadManagement.Api.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is LeadManagementException)
        {
            HandleException(context);
        }
        else
        {
            ThrowUnkownException(context);
        }
    }

    private void HandleException(ExceptionContext context)
    {

        if (context.Exception is ErrorOnValidationException)
        {

            var ex = (ErrorOnValidationException)context.Exception;

            var erroResponse = new ResponseErrorJson(ex.Errors);
            context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.Result = new BadRequestObjectResult(erroResponse);
        }
        else
        {
            var erroResponse = new ResponseErrorJson(context.Exception.Message);
            context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.Result = new BadRequestObjectResult(erroResponse);
        }
    }

    private void ThrowUnkownException(ExceptionContext context)
    {

        var erroResponse = new ResponseErrorJson("Unknown error");

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(erroResponse);
    }
}
