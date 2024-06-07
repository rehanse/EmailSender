using EmailSender.Models;
using EmailSender.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;

namespace EmailSender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceSenderController : ControllerBase
    {
        private readonly IServices _services;
        public ServiceSenderController(IServices services)
        {
                _services = services;
        }
        [HttpPost("SendtextNotification")]
        public async Task<ActionResult> SendText([FromBody] TextRequestModel model)
        {
            bool result = await _services.SendTextService(model);
            return Ok(result);
        }
    }
}
