using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TicketMicroservice.Web.Controllers
{
    [Authorize]
    [Route("ticket/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        public TicketsController()
        {
        }

        [HttpGet]
        public async Task<ActionResult<string>> AuthorizedTicket()
        {
            string result = "Authorized for this Ticket controller";
            return result;
        }
    }
}
