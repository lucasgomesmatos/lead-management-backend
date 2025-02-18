using Azure;
using LeadManagement.Application.UseCases.Lead.Accepted;
using LeadManagement.Application.UseCases.Lead.Declined;
using LeadManagement.Application.UseCases.Lead.Invited.List;
using LeadManagement.Application.UseCases.Lead.Invited.Register;
using LeadManagement.Communication.Requests;
using LeadManagement.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LeadManagement.Api.Controllers
{
    
    [Route("api/leads")]
    [ApiController]
    public class LeadsController : ControllerBase
    {


        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        [HttpPost("register")]
        public async Task<IActionResult> RegisterLead(
            [FromServices] IRegisterLeadUseCase useCase,
            [FromBody] RequestLeadJson request)
        {
            await useCase.Execute(request);

            return Created();
        }

        [ProducesResponseType(typeof(ResponseInvitedLeadJson), StatusCodes.Status200OK)]
        [HttpGet("invited")]
        public async Task<IActionResult> GetInvitedLeads(
            [FromServices] IListAllInvitedLeadUseCase useCase,
             [FromQuery] string status
        )
        {
            var result = await useCase.Execute(status);

            return Ok(result);
        }

        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        [HttpPut("{leadId}/accept")]
        public async Task<IActionResult> AcceptLead(
           [FromServices] IUpdateStatusLeadAcceptedUseCase useCase,
           int leadId
        )
        {
            await useCase.Execute(leadId);

            return Created();
        }

        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        [HttpPut("{leadId}/decline")]
        public async Task<IActionResult> DeclineLead(
          [FromServices] IUpdateStatusLeadDeclinedUseCase useCase,
          int leadId
       )
        {
            await useCase.Execute(leadId);

            return Created();
        }
    }
}